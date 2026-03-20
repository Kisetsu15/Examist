using System;
using System.Diagnostics;
using System.IO;

namespace Examist {
    public class Python : ILanguage {
        private const string ERROR_MESSAGE = "fatal: The original bugged program could not be found.";
        private readonly LanguageConfig config;
        public int Level => config.Level;

        public string Question => LoadQuestion();

        public Python(LanguageConfig config) {
            this.config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public VerificationResult Verify(string program) {
            return RunTester(program);
        }

        public string GetBuggedProgram() {
            string path = Language.ResolvePath(config.BuggedProgramPath);
            if (path == null) {
                return ERROR_MESSAGE;
            }

            try {
                return File.ReadAllText(path);
            } catch {
                return ERROR_MESSAGE;
            }
        }

        private string LoadQuestion() {
            string path = Language.ResolvePath(config.QuestionPath);
            if (path == null) {
                return string.Empty;
            }

            try {
                return File.ReadAllText(path);
            } catch {
                return string.Empty;
            }
        }

        private VerificationResult RunTester(string program) {
            string userPath = Language.ResolveOutputPath(config.UserProgramPath);
            if (userPath == null) {
                return VerificationResult.Error("Tester failed: User program path is not configured.");
            }

            string testerScriptPath = Language.ResolvePath(config.TesterScriptPath);
            if (testerScriptPath == null) {
                return VerificationResult.Error("Tester failed: tester python script was not found.");
            }

            try {
                Directory.CreateDirectory(Path.GetDirectoryName(userPath));
                File.WriteAllText(userPath, program ?? string.Empty);
            } catch (Exception ex) {
                return VerificationResult.Error($"Tester failed: could not save your code. {ex.Message}");
            }

            string testerCommand = string.IsNullOrWhiteSpace(config.TesterCommand) ? Strings.PYTHON : config.TesterCommand;
            string arguments = Language.BuildTesterArguments(testerScriptPath, userPath, config);

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

                    string output = process.StandardOutput.ReadToEnd().Trim();
                    string error = process.StandardError.ReadToEnd().Trim();
                    process.WaitForExit();

                    switch (Language.ParseTesterResult(output, error)) {
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
