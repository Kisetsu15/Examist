using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Examist {
    public sealed class Config {
        private static readonly Lazy<Config> current = new Lazy<Config>(Load);
        private static readonly string trustedContentRoot = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".emt"));

        public static Config Current => current.Value;

        public string TesterCommand { get; set; }
        public TesterScriptsConfig TesterScripts { get; set; }
        public ServerConfig Server { get; set; }
        public List<LevelDefinition> Levels { get; set; }

        public LevelDefinition GetLevel(int levelNumber) {
            LevelDefinition level = (Levels?.FirstOrDefault(item => item.Number == levelNumber)) ??
                throw new InvalidOperationException($"Level {levelNumber} is not defined in .emt\\config.json.");
            return level;
        }

        private static Config Load() {
            string path = ResolveConfigPath();
            string json = File.ReadAllText(path);
            Config config = JsonConvert.DeserializeObject<Config>(json) ??
                throw new InvalidOperationException(".emt\\config.json could not be parsed.");

            config.ApplyDefaults();
            return config;
        }

        private void ApplyDefaults() {
            if (Levels == null) {
                return;
            }

            foreach (LevelDefinition level in Levels) {
                ApplyLanguageDefaults(level?.Languages?.Java, level?.Number ?? 0, TesterScripts?.Java, TesterCommand);
                ApplyLanguageDefaults(level?.Languages?.Python, level?.Number ?? 0, TesterScripts?.Python, TesterCommand);
            }
        }

        private static void ApplyLanguageDefaults(
            LanguageConfig language, int level, string testerScriptPath, string testerCommand) {

            if (language == null) {
                return;
            }

            language.Level = level;
            language.TesterCommand = string.IsNullOrWhiteSpace(language.TesterCommand)
                ? (string.IsNullOrWhiteSpace(testerCommand) ? Strings.PYTHON : testerCommand)
                : language.TesterCommand;
            language.TesterScriptPath = string.IsNullOrWhiteSpace(language.TesterScriptPath)
                ? testerScriptPath
                : language.TesterScriptPath;
        }

        private static string ResolveConfigPath() {
            string candidate = Path.Combine(trustedContentRoot, "config.json");
            if (File.Exists(candidate)) {
                return candidate;
            }

            throw new FileNotFoundException(".emt\\config.json could not be found in " + trustedContentRoot + ".");
        }
    }

    public sealed class TesterScriptsConfig {
        public string Java { get; set; }
        public string Python { get; set; }
    }


    public sealed class ServerConfig {
        public string BaseUrl { get; set; }
    }

    public sealed class LevelDefinition {
        public int Number { get; set; }
        public int TimeInMinutes { get; set; }
        public LevelLanguages Languages { get; set; }
    }

    public sealed class LevelLanguages {
        public LanguageConfig Java { get; set; }
        public LanguageConfig Python { get; set; }
    }

    public sealed class LanguageConfig {
        public int Level { get; set; }
        public string QuestionPath { get; set; }
        public string BuggedPath { get; set; }
        public string UserPath { get; set; }
        public string OutputPath { get; set; }
        public string TesterCommand { get; set; }
        public string TesterScriptPath { get; set; }
    }
}
