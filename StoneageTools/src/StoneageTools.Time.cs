
using System;

namespace StoneageTools.Time
{
    public static class StoneageToolsTime
    {
        public static int Days_2_Month(int daynumber)    // 1 to 366
        {
            double result = daynumber / 30.4368499;             // good guess
            return (int)result;
        }

        public static double Milliseconds_2_Days(double milliseconds)
        {
            return TimeSpan.FromMilliseconds(milliseconds).TotalDays;
        }

        public static double Seconds_2_Days(double seconds)
        {
            return TimeSpan.FromSeconds(seconds).TotalDays;
        }

        public static double Minutes_2_Days(double minutes)
        {
            return TimeSpan.FromMinutes(minutes).TotalDays;
        }

        public static double Hours_2_Days(double hours)
        {
            return TimeSpan.FromHours(hours).TotalDays;
        }

        public static double Milliseconds_2_Hours(double milliseconds)
        {
            return TimeSpan.FromMilliseconds(milliseconds).TotalHours;
        }

        public static double Seconds_2_Hours(double seconds)
        {
            return TimeSpan.FromSeconds(seconds).TotalHours;
        }

        public static double Minutes_2_Hours(double minutes)
        {
            return TimeSpan.FromMinutes(minutes).TotalHours;
        }

        public static double Days_2_Hours(double days)
        {
            return TimeSpan.FromHours(days).TotalHours;
        }

        public static double Milliseconds_2_Minutes(double milliseconds)
        {
            return TimeSpan.FromMilliseconds(milliseconds).TotalMinutes;
        }

        public static double Seconds_2_Minutes(double seconds)
        {
            return TimeSpan.FromSeconds(seconds).TotalMinutes;
        }

        public static double Hours_2_Minutes(double hours)
        {
            return TimeSpan.FromHours(hours).TotalMinutes;
        }

        public static double Days_2_Minutes(double days)
        {
            return TimeSpan.FromDays(days).TotalMinutes;
        }

        public static double Milliseconds_2_Seconds(double milliseconds)
        {
            return TimeSpan.FromMilliseconds(milliseconds).TotalSeconds;
        }

        public static double Minutes_2_Seconds(double minutes)
        {
            return TimeSpan.FromMinutes(minutes).TotalSeconds;
        }

        public static double Hours_2_Seconds(double hours)
        {
            return TimeSpan.FromHours(hours).TotalSeconds;
        }

        public static double Days_2_Seconds(double days)
        {
            return TimeSpan.FromDays(days).TotalSeconds;
        }

        public static double Seconds_2_Milliseconds(double seconds)
        {
            return TimeSpan.FromSeconds(seconds).TotalMilliseconds;
        }

        public static double Minutes_2_Milliseconds(double minutes)
        {
            return TimeSpan.FromMinutes(minutes).TotalMilliseconds;
        }

        public static double Hours_2_Milliseconds(double hours)
        {
            return TimeSpan.FromHours(hours).TotalMilliseconds;
        }

        public static double Days_2_Milliseconds(double days)
        {
            return TimeSpan.FromDays(days).TotalMilliseconds;
        }

        public static double Milliseconds_2_Nanoseconds(double milliseconds)
        {
            return milliseconds * 1000000;
        }

        public static double Microseconds_2_Nanoseconds(double microseconds)
        {
            return microseconds * 1000;
        }

        public static double Milliseconds_2_Microseconds(double milliseconds)
        {
            return milliseconds * 1000;
        }

        public static double Nanoseconds_2_Milliseconds(double nanoseconds)
        {
            return nanoseconds * 0.000001;
        }

        public static double Microseconds_2_Milliseconds(double microseconds)
        {
            return microseconds * 0.001;
        }

        public static double Nanoseconds_2_Microseconds(double nanoseconds)
        {
            return nanoseconds * 0.001;
        }
    }
}
