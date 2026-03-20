using System;
using System.IO;

namespace Examist {
    public static class Language {
        public static string BuildTesterArguments(string testerScriptPath, string userPath, string outputPath) {
            return $"\"{testerScriptPath}\" \"{userPath}\" \"{outputPath}\"";
        }

        public static string ParseTesterResult(string output, string error) {
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

        public static string ResolveOutputPath(string configuredPath) {
            if (string.IsNullOrWhiteSpace(configuredPath)) {
                return null;
            }

            string[] candidates = {
                configuredPath,
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configuredPath),
                Path.Combine(Environment.CurrentDirectory, configuredPath)
            };

            foreach (string candidate in candidates) {
                string fullPath = Path.GetFullPath(candidate);
                string directory = Path.GetDirectoryName(fullPath);
                if (!string.IsNullOrWhiteSpace(directory)) {
                    return fullPath;
                }
            }

            return null;
        }

        public static string ResolvePath(string configuredPath) {
            if (string.IsNullOrWhiteSpace(configuredPath)) {
                return null;
            }

            string[] candidates = {
                configuredPath,
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configuredPath),
                Path.Combine(Environment.CurrentDirectory, configuredPath)
            };

            foreach (string candidate in candidates) {
                string fullPath = Path.GetFullPath(candidate);
                if (File.Exists(fullPath)) {
                    return fullPath;
                }
            }

            return null;
        }
    }
}
