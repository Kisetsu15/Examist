using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
namespace Examist {
    public class Python : Language {
        private const int TesterTimeoutMilliseconds = 10000;
        private readonly LanguageConfig config;
        public override int Level => config.Level;
        public override string Question => Load(config.QuestionPath);
        public Python(LanguageConfig config) {
            this.config = config ?? throw new ArgumentNullException(nameof(config));
        }
        public override VerificationResult Verify(string program) {
            return RunTester(program);
        }
        public override string GetBuggedProgram() {
            return Load(config.BuggedPath);
        }
        private VerificationResult RunTester(string program) {
            string userPath = ResolveOutputPath(config.UserPath);
            string outputPath = ResolveOutputPath(config.OutputPath);
            if (userPath == null) {
                return VerificationResult.Error("Tester failed: user file path is not configured.");
            }
            if (outputPath == null) {
                return VerificationResult.Error("Tester failed: output file path is not configured.");
            }
            string testerScriptPath = ResolvePath(config.TesterScriptPath);
            if (testerScriptPath == null) {
                return VerificationResult.Error("Tester failed: tester python script was not found.");
            }
            try {
                Directory.CreateDirectory(Path.GetDirectoryName(userPath));
                Directory.CreateDirectory(Path.GetDirectoryName(outputPath));
                File.WriteAllText(userPath, program ?? string.Empty);
            } catch (Exception ex) {
                return VerificationResult.Error($"Tester failed: could not save your code. {ex.Message}");
            }
            string testerCommand = string.IsNullOrWhiteSpace(config.TesterCommand)
                ? Strings.PYTHON
                : config.TesterCommand;
            string arguments = BuildTesterArguments(testerScriptPath, userPath, outputPath);
            try {
                var startInfo = new ProcessStartInfo {
                    FileName = testerCommand,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory
                };
                using (var process = Process.Start(startInfo)) {
                    if (process == null) {
                        return VerificationResult.Error("Tester failed: process could not be started.");
                    }
                    Task<string> outputTask = Task.Run(() => process.StandardOutput.ReadToEnd());
                    Task<string> errorTask = Task.Run(() => process.StandardError.ReadToEnd());
                    if (!process.WaitForExit(TesterTimeoutMilliseconds) ||
                        !Task.WaitAll(new Task[] { outputTask, errorTask }, TesterTimeoutMilliseconds)) {
                        try {
                            process.Kill();
                        } catch {
                        }
                        return VerificationResult.Error("Tester timed out.");
                    }
                    string output = outputTask.Result.Trim();
                    string error = errorTask.Result.Trim();
                    switch (ParseTesterResult(output, error)) {
                        case Strings.SUCCESS:
                            return VerificationResult.Success("Verified");
                        case Strings.INVALID:
                            return VerificationResult.Invalid("Program output matched, but the solution changed too much.");
                        case Strings.ERROR:
                            return VerificationResult.Error("Contains errors.");
                    }
                    string message = !string.IsNullOrWhiteSpace(error) ? error : output;
                    return VerificationResult.Error(string.IsNullOrWhiteSpace(message) ? "Verification failed." : message);
                }
            } catch (Exception ex) {
                return VerificationResult.Error($"Tester failed: {ex.Message}");
            }
        }
    }
}