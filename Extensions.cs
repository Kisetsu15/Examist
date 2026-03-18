using System.Windows.Forms;

namespace Examist {
    public static class Extensions {
        public static void SetActive(this Control control, bool active) {
            control.Enabled = active;
        }

        public static string PadZero(this object text, int width = 2) {
            return text.ToString().PadLeft(width, '0');
        }
    }
}