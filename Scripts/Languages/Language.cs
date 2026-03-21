using System;
using System.IO;

namespace Examist {
    public abstract class Language : ILanguage {
        private static readonly string trustedContentRoot = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".emt"));

        public abstract int Level { get; }
        public abstract string Question { get; }

        protected static string BuildTesterArguments(string testerScriptPath, string userPath, string outputPath) {
            return $"\"{testerScriptPath}\" \"{userPath}\" \"{outputPath}\"";
        }

        protected static string ParseTesterResult(string output, string error) {
            string combined = $"{output} {error}".Trim();
            if (string.IsNullOrWhiteSpace(combined)) {
                return string.Empty;
            }

            string normalized = combined.ToLowerInvariant();
            if (normalized.Contains(Strings.SUCCESS)) {
                return Strings.SUCCESS;
            }

            if (normalized.Contains(Strings.INVALID)) {
                return Strings.INVALID;
            }

            if (normalized.Contains(Strings.ERROR)) {
                return Strings.ERROR;
            }

            return string.Empty;
        }

        protected static string ResolveOutputPath(string configuredPath) {
            return ResolveTrustedPath(configuredPath, requireExistingFile: false);
        }

        protected static string ResolvePath(string configuredPath) {
            return ResolveTrustedPath(configuredPath, requireExistingFile: true);
        }

        protected static string Load(string filePath) {
            string path = ResolvePath(filePath);
            if (path == null) {
                return string.Empty;
            }

            try {
                return File.ReadAllText(path);
            } catch {
                return string.Empty;
            }
        }

        public abstract VerificationResult Verify(string program);
        public abstract string GetBuggedProgram();

        private static string ResolveTrustedPath(string configuredPath, bool requireExistingFile) {
            if (string.IsNullOrWhiteSpace(configuredPath)) {
                return null;
            }

            string sanitizedPath = configuredPath.Trim();
            string fullPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, sanitizedPath));

            if (!IsUnderTrustedContentRoot(fullPath)) {
                return null;
            }

            if (requireExistingFile && !File.Exists(fullPath)) {
                return null;
            }

            string directory = Path.GetDirectoryName(fullPath);
            if (string.IsNullOrWhiteSpace(directory)) {
                return null;
            }

            return fullPath;
        }

        private static bool IsUnderTrustedContentRoot(string fullPath) {
            if (string.IsNullOrWhiteSpace(fullPath)) {
                return false;
            }

            string normalizedRoot = EnsureTrailingSeparator(trustedContentRoot);
            string normalizedPath = EnsureTrailingSeparator(fullPath);

            return normalizedPath.StartsWith(normalizedRoot, StringComparison.OrdinalIgnoreCase);
        }

        private static string EnsureTrailingSeparator(string path) {
            if (string.IsNullOrWhiteSpace(path)) {
                return path;
            }

            return path.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                + Path.DirectorySeparatorChar;
        }
    }
}
