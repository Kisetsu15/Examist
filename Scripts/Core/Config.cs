using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Examist {
    public sealed class Config {
        private static readonly Lazy<Config> current = new Lazy<Config>(Load);

        public static Config Current => current.Value;

        [JsonProperty("testerCommand")]
        public string TesterCommand { get; set; }

        [JsonProperty("testerScripts")]
        public TesterScriptsConfig TesterScripts { get; set; }

        [JsonProperty("levels")]
        public List<LevelDefinition> Levels { get; set; }

        public LevelDefinition GetLevel(int levelNumber) {
            LevelDefinition level = Levels?.FirstOrDefault(item => item.Number == levelNumber);
            if (level == null) {
                throw new InvalidOperationException($"Level {levelNumber} is not defined in .emt\\config.json.");
            }

            return level;
        }

        private static Config Load() {
            string path = ResolveConfigPath();
            string json = File.ReadAllText(path);
            Config config = JsonConvert.DeserializeObject<Config>(json) ?? throw new InvalidOperationException(".emt\\config.json could not be parsed.");
            config.ApplyDefaults();
            return config;
        }

        private void ApplyDefaults() {
            if (Levels == null) {
                return;
            }

            foreach (LevelDefinition level in Levels) {
                ApplyLanguageDefaults(level?.Languages?.Java, level?.Number ?? 0, TesterScripts?.Java);
                ApplyLanguageDefaults(level?.Languages?.Python, level?.Number ?? 0, TesterScripts?.Python);
            }
        }

        private static void ApplyLanguageDefaults(LanguageConfig language, int level, string testerScriptPath) {
            if (language == null) {
                return;
            }

            language.Level = level;
            language.TesterCommand = Strings.PYTHON;
            language.TesterScriptPath = testerScriptPath;
        }

        private static string ResolveConfigPath() {
            string[] candidates = {
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".emt", "config.json"),
                Path.Combine(Environment.CurrentDirectory, ".emt", "config.json"),
                Path.GetFullPath(Path.Combine(".emt", "config.json")),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json"),
                Path.Combine(Environment.CurrentDirectory, "config.json"),
                Path.GetFullPath("config.json")
            };

            foreach (string candidate in candidates) {
                if (File.Exists(candidate)) {
                    return candidate;
                }
            }

            throw new FileNotFoundException(".emt\\config.json could not be found.");
        }
    }

    public sealed class TesterScriptsConfig {
        [JsonProperty("python")]
        public string Python { get; set; }

        [JsonProperty("java")]
        public string Java { get; set; }
    }

    public sealed class LevelDefinition {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("languages")]
        public LevelLanguages Languages { get; set; }
    }

    public sealed class LevelLanguages {
        [JsonProperty("java")]
        public LanguageConfig Java { get; set; }

        [JsonProperty("python")]
        public LanguageConfig Python { get; set; }
    }

    public sealed class LanguageConfig {
        public int Level { get; set; }

        [JsonProperty("question")]
        public string QuestionPath { get; set; }

        [JsonProperty("buggedProgram")]
        public string BuggedProgramPath { get; set; }

        [JsonProperty("userProgram")]
        public string UserProgramPath { get; set; }

        public string TesterCommand { get; set; }
        public string TesterScriptPath { get; set; }
        public string TesterArguments { get; set; }
    }
}
