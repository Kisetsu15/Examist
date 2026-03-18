using System;

namespace Examist {
    struct Time {
        int now;

        int Minutes => Now / 60;
        int Seconds => Now % 60;

        public Time(int timeInSeconds) {
            now = timeInSeconds;
        }

        public int Now {
            get => now;
            set => now = Math.Max(value, 0);
        }

        public bool IsEnded => Now <= 0;
        public string NowAsString => $"{Minutes.PadZero()}:{Seconds.PadZero()}";
    }
}