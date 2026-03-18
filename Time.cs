using System;

namespace Examist {
    public class Time {
        readonly int initialTime;
        int timeLeft;

        int TimeSpent => initialTime - timeLeft;

        public int TimeLeft {
            get => timeLeft;
            set => timeLeft = Math.Max(value, 0);
        }

        public Time(int timeInSeconds) {
            initialTime = timeInSeconds;
            timeLeft = timeInSeconds;
        }

        public bool IsEnded => TimeLeft <= 0;
        public string TimeLeftString => $"{Minutes(timeLeft).PadZero()}:{Seconds(timeLeft).PadZero()}";
        public string TimeSpentString => $"{Minutes(TimeSpent).PadZero()}:{Seconds(TimeSpent).PadZero()}";


        public int Minutes(int time)
        {
            return time / 60;
        }

        public int Seconds(int time)
        {
            return time % 60;
        }
    }
}