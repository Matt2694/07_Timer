using System;

namespace _07_Timer{

    internal class Timer{

        private int seconds = 0;
        private int hours = 0;
        private int minutes = 0;
        private int newSeconds = 0;
        public int Seconds{

            get{
                return seconds;
            }
            internal set{
                seconds = value;
                SecondsToHMS();
            }
        }
        public override string ToString(){

            string format = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, newSeconds);
            return format;
        }
        public void SecondsToHMS(){

            int holding;
            newSeconds = Seconds % 60;
            holding = Seconds - newSeconds;
            minutes = holding / 60;
            holding = minutes % 60;
            hours = minutes - holding;
            minutes = holding;
            hours = hours / 60;
            if (hours < 1){
                hours = 0;
            }
        }
    }
}