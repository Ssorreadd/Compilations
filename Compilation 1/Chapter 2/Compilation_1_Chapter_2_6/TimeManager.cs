using System;

namespace Compilation_1_Chapter_2_6
{
    public static class TimeManager
    {
        //3 600 секунд в часу;
        public static int CountOfSeconds { get; private set; }

        public static void SetSeconds(int seconds) => CountOfSeconds = seconds;

        public static int GetFullHours()
        {
            if (CountOfSeconds < 3600)
                return 0;

            return (int)Math.Round(((double)CountOfSeconds / 60) / 60);     
        }

        public static int GetFullMinutes()
        {
            double seconds = CountOfSeconds;

            int hours = GetFullHours();

            if (hours != 0)
            {
                while (hours != 1)
                {
                    seconds -= 3600;
                    hours--;
                }
            }

            int minutes = (int)Math.Round(seconds / 60);
            
            if (minutes > 60)
            {
                minutes -= 60;
            }

            return minutes;
        }

        public static int GetFullSeconds()
        {
            int hours = GetFullHours();

            int seconds = CountOfSeconds;

            if (hours != 0)
            {
                while (hours != 1)
                {
                    seconds -= 3600;
                    hours--;
                }
            }
            
            while (seconds - 60 > 0)
            {
                seconds -= 60;
            }

            return seconds;
        }
    }
}