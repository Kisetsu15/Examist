using System.Windows.Forms;

namespace Examist {
    public static class Extensions {
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
    }
}