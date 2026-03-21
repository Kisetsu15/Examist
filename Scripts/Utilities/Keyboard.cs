using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Examist {
    public static class Keyboard {
        private static IntPtr hookId = IntPtr.Zero;
        private static LowLevelKeyboardProc proc = HookCallback;

        public static void Start() {
            hookId = SetHook(proc);
        }

        public static void Stop() {
            UnhookWindowsHookEx(hookId);
        }

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr SetHook(LowLevelKeyboardProc proc) {
            using (var curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule) {
                return SetWindowsHookEx(
                    13,
                    proc,
                    GetModuleHandle(curModule.ModuleName),
                    0);
            }
        }

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam) {
            if (nCode >= 0) {
                int vkCode = Marshal.ReadInt32(lParam);
                var key = (Keys) vkCode;

                // BLOCK WINDOWS KEY
                if (key == Keys.LWin || key == Keys.RWin) {
                    return (IntPtr) 1;
                }

                // OPTIONAL: block more shortcuts
                if ((Control.ModifierKeys & Keys.Alt) != 0 && key == Keys.Tab) {
                    return (IntPtr) 1;
                }

                if ((Control.ModifierKeys & Keys.Alt) != 0 && key == Keys.F4) {
                    return (IntPtr) 1;
                }

                if (key == Keys.Escape && Control.ModifierKeys == Keys.Control) {
                    return (IntPtr) 1;
                }
            }

            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        // WinAPI
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(
            int idHook,
            LowLevelKeyboardProc lpfn,
            IntPtr hMod,
            uint dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(
            IntPtr hhk,
            int nCode,
            IntPtr wParam,
            IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}