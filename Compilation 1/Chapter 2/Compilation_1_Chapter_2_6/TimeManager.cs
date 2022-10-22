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
            //1 минута = 60 секунд;
            //1 час = 60 минут;
            return (int)Math.Round(((double)CountOfSeconds / 60) / 60);     
        }

        public static int GetFullMinutes()
        {
            double seconds = CountOfSeconds;

            int hours = GetFullHours();

            //3200 сек
            //400сек
            //

            while (hours != 1)
            {
                seconds -= 3600;
                hours--;
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

            while (hours != 1)
            {
                seconds -= 3600;
                hours--;
            }

            while (seconds - 60 > 0)
            {
                seconds -= 60;
            }

            return seconds;
        }
    }
}
