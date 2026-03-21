using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Examist {
    public static class Extensions {
        private static readonly string resultsPath = Path.GetFullPath(
            Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, ".emt", "results.json"));

        public static void Enable(this Control control) {
            control.Enabled = true;
        }

        public static void Disable(this Control control) {
            control.Enabled = false;
        }

        public static string PadZero(this object text, int width = 2) {
            return text.ToString().PadLeft(width, '0');
        }

        public static void SwitchForm(this Form currentForm, Form nextForm) {
            nextForm.Show();

            currentForm.Hide();
        }

        public static void SaveResults(Student student, string time, int level) {
            string directory = Path.GetDirectoryName(resultsPath);
            if (!string.IsNullOrWhiteSpace(directory)) {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(resultsPath)) {
                File.WriteAllText(resultsPath, "{}");
            }

            string json = File.ReadAllText(resultsPath);

            Dictionary<string, Dictionary<int, string>> results =
                JsonConvert.DeserializeObject<Dictionary<string, Dictionary<int, string>>>(json)
                ?? new Dictionary<string, Dictionary<int, string>>();

            if (results.TryGetValue(student.BatchNumber, out Dictionary<int, string> value)) {
                value[level] = time; // FIX: avoids duplicate key crash
            } else {
                results[student.BatchNumber] = new Dictionary<int, string> { { level, time } };
            }

            File.WriteAllText(resultsPath, JsonConvert.SerializeObject(results, Formatting.Indented));
        }

        public static void WindowStyle(this Form form) {
            form.WindowState = FormWindowState.Maximized;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopMost = true;
        }
    }


}