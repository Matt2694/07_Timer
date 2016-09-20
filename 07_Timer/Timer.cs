using System;

namespace _07_Timer
{
    internal class Timer
    {
        private double seconds = 0;
        private double hours = 0;
        private double minutes = 0;
        private double newSeconds = 0;
        public double Seconds
        {
            get
            {
                return seconds;
            }
            internal set
            {
                seconds = value;
                SecondsToHMS();
            }
        }
        public override string ToString()
        {
            string format = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, newSeconds);
            return format;
        }
        public void SecondsToHMS()
        {
            double holding;
            double holding2;
            newSeconds = Seconds % 60;
            holding = Seconds - newSeconds;
            minutes = holding / 60;
            holding2 = minutes % 60;
            hours = minutes - holding2;
            minutes = holding2;
            hours = hours / 60;
            if (hours < 1)
            {
                hours = 0;
            }
        }
    }
}