using Newtonsoft.Json;
using System;
using System.IO;

namespace Examist {
    public sealed class Config {
        private static readonly Lazy<Config> current = new Lazy<Config>(Load);

        public static Config Current => current.Value;

        public LevelConfig LevelOne { get; set; }
        public LevelConfig LevelTwo { get; set; }

        private static Config Load() {
            string path = ResolveConfigPath();
            string json = File.ReadAllText(path);
            Config config = JsonConvert.DeserializeObject<Config>(json) ?? throw new InvalidOperationException("config.json could not be parsed.");
            return config;
        }

        private static string ResolveConfigPath() {
            string[] candidates = {
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json"),
                Path.Combine(Environment.CurrentDirectory, "config.json"),
                Path.GetFullPath("config.json")
            };

            foreach (string candidate in candidates) {
                if (File.Exists(candidate)) {
                    return candidate;
                }
            }

            throw new FileNotFoundException("config.json could not be found.");
        }
    }

    public sealed class LevelConfig {
        public LanguageConfig Java { get; set; }
        public LanguageConfig Python { get; set; }
    }

    public sealed class LanguageConfig {
        public string Question { get; set; }
        public string BuggedProgramPath { get; set; }
        public string UserProgramPath { get; set; }
        public string TesterCommand { get; set; }
        public string TesterScriptPath { get; set; }
        public string TesterArguments { get; set; }
    }
}
