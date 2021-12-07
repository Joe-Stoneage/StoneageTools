
using System;

namespace StoneageTools.Time
{
    public static partial class StoneageToolsUnits
    {
        #region time
        public static int Days_2_Month(int daynumber)    // 1 to 366
        {
            double result = daynumber / 30.4368499;      // good guess
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

        /// <summary>
        /// ms -> s
        /// 1 millisecond [ms] to vv: 0.001 second [s]
        /// </summary>
        public static double Millisecond_2_Second(double inVal)                         => inVal * 0.001;
        /// <summary>
        /// s -> ms
        /// vv: 0.001 second [s] to 1 millisecond [ms]
        /// </summary>
        public static double Second_2_Millisecond(double inVal)                         => inVal / 0.001;

        /// <summary>
        /// min -> s
        /// 1 minute [min] to vv: 60 second [s]
        /// </summary>
        public static double Minute_2_Second(double inVal)                              => inVal * 60;
        /// <summary>
        /// s -> min
        /// vv: 60 second [s] to 1 minute [min]
        /// </summary>
        public static double Second_2_Minute(double inVal)                              => inVal / 60;

        /// <summary>
        /// h -> s
        /// 1 hour [h] to vv: 3600 second [s]
        /// </summary>
        public static double Hour_2_Second(double inVal)                                => inVal * 3600;
        /// <summary>
        /// s -> h
        /// vv: 3600 second [s] to 1 hour [h]
        /// </summary>
        public static double Second_2_Hour(double inVal)                                => inVal / 3600;

        /// <summary>
        /// d -> s
        /// 1 day [d] to vv: 86400 second [s]
        /// </summary>
        public static double Day_2_Second(double inVal)                                 => inVal * 86400;
        /// <summary>
        /// s -> d
        /// vv: 86400 second [s] to 1 day [d]
        /// </summary>
        public static double Second_2_Day(double inVal)                                 => inVal / 86400;

        /// <summary>
        /// Week -> s
        /// 1 week to vv: 604800 second [s]
        /// </summary>
        public static double Week_2_Second(double inVal)                                => inVal * 604800;
        /// <summary>
        /// s -> Week
        /// vv: 604800 second [s] to 1 week
        /// </summary>
        public static double Second_2_Week(double inVal)                                => inVal / 604800;

        /// <summary>
        /// Month -> s
        /// 1 month to vv: 2628000 second [s]
        /// </summary>
        public static double Month_2_Second(double inVal)                               => inVal * 2628000;
        /// <summary>
        /// s -> Month
        /// vv: 2628000 second [s] to 1 month
        /// </summary>
        public static double Second_2_Month(double inVal)                               => inVal / 2628000;

        /// <summary>
        /// y -> s
        /// 1 year [y] to vv: 31536000 second [s]
        /// </summary>
        public static double Year_2_Second(double inVal)                                => inVal * 31536000;
        /// <summary>
        /// s -> y
        /// vv: 31536000 second [s] to 1 year [y]
        /// </summary>
        public static double Second_2_Year(double inVal)                                => inVal / 31536000;

        /// <summary>
        /// Decade -> s
        /// 1 decade to vv: 315360000 second [s]
        /// </summary>
        public static double Decade_2_Second(double inVal)                              => inVal * 315360000;
        /// <summary>
        /// s -> Decade
        /// vv: 315360000 second [s] to 1 decade
        /// </summary>
        public static double Second_2_Decade(double inVal)                              => inVal / 315360000;

        /// <summary>
        /// Century -> s
        /// 1 century to vv: 3153600000 second [s]
        /// </summary>
        public static double Century_2_Second(double inVal)                             => inVal * 3153600000;
        /// <summary>
        /// s -> Century
        /// vv: 3153600000 second [s] to 1 century
        /// </summary>
        public static double Second_2_Century(double inVal)                             => inVal / 3153600000;

        /// <summary>
        /// Millennium -> s
        /// 1 millennium to vv: 31536000000 second [s]
        /// </summary>
        public static double Millennium_2_Second(double inVal)                          => inVal * 31536000000;
        /// <summary>
        /// s -> Millennium
        /// vv: 31536000000 second [s] to 1 millennium
        /// </summary>
        public static double Second_2_Millennium(double inVal)                          => inVal / 31536000000;

        /// <summary>
        /// µs -> s
        /// 1 microsecond [µs] to vv: 1.0E-6 second [s]
        /// </summary>
        public static double Microsecond_2_Second(double inVal)                         => inVal * 1.0E-6;
        /// <summary>
        /// s -> µs
        /// vv: 1.0E-6 second [s] to 1 microsecond [µs]
        /// </summary>
        public static double Second_2_Microsecond(double inVal)                         => inVal / 1.0E-6;

        /// <summary>
        /// ns -> s
        /// 1 nanosecond [ns] to vv: 1.0E-9 second [s]
        /// </summary>
        public static double Nanosecond_2_Second(double inVal)                          => inVal * 1.0E-9;
        /// <summary>
        /// s -> ns
        /// vv: 1.0E-9 second [s] to 1 nanosecond [ns]
        /// </summary>
        public static double Second_2_Nanosecond(double inVal)                          => inVal / 1.0E-9;

        /// <summary>
        /// ps -> s
        /// 1 picosecond [ps] to vv: 1.0E-12 second [s]
        /// </summary>
        public static double Picosecond_2_Second(double inVal)                          => inVal * 1.0E-12;
        /// <summary>
        /// s -> ps
        /// vv: 1.0E-12 second [s] to 1 picosecond [ps]
        /// </summary>
        public static double Second_2_Picosecond(double inVal)                          => inVal / 1.0E-12;

        /// <summary>
        /// fs -> s
        /// 1 femtosecond [fs] to vv: 1.0E-15 second [s]
        /// </summary>
        public static double Femtosecond_2_Second(double inVal)                         => inVal * 1.0E-15;
        /// <summary>
        /// s -> fs
        /// vv: 1.0E-15 second [s] to 1 femtosecond [fs]
        /// </summary>
        public static double Second_2_Femtosecond(double inVal)                         => inVal / 1.0E-15;

        /// <summary>
        /// as -> s
        /// 1 attosecond [as] to vv: 1.0E-18 second [s]
        /// </summary>
        public static double Attosecond_2_Second(double inVal)                          => inVal * 1.0E-18;
        /// <summary>
        /// s -> as
        /// vv: 1.0E-18 second [s] to 1 attosecond [as]
        /// </summary>
        public static double Second_2_Attosecond(double inVal)                          => inVal / 1.0E-18;

        /// <summary>
        /// Shake -> s
        /// 1 shake to vv: 1.0E-8 second [s]
        /// </summary>
        public static double Shake_2_Second(double inVal)                               => inVal * 1.0E-8;
        /// <summary>
        /// s -> Shake
        /// vv: 1.0E-8 second [s] to 1 shake
        /// </summary>
        public static double Second_2_Shake(double inVal)                               => inVal / 1.0E-8;

        /// <summary>
        /// MonthSynodic -> s
        /// 1 month (synodic) to vv: 2551443.84 second [s]
        /// </summary>
        public static double MonthSynodic_2_Second(double inVal)                        => inVal * 2551443.84;
        /// <summary>
        /// s -> MonthSynodic
        /// vv: 2551443.84 second [s] to 1 month (synodic)
        /// </summary>
        public static double Second_2_MonthSynodic(double inVal)                        => inVal / 2551443.84;

        /// <summary>
        /// YearJulian -> s
        /// 1 year (Julian) to vv: 31557600 second [s]
        /// </summary>
        public static double YearJulian_2_Second(double inVal)                          => inVal * 31557600;
        /// <summary>
        /// s -> YearJulian
        /// vv: 31557600 second [s] to 1 year (Julian)
        /// </summary>
        public static double Second_2_YearJulian(double inVal)                          => inVal / 31557600;

        /// <summary>
        /// YearLeap -> s
        /// 1 year (leap) to vv: 31622400 second [s]
        /// </summary>
        public static double YearLeap_2_Second(double inVal)                            => inVal * 31622400;
        /// <summary>
        /// s -> YearLeap
        /// vv: 31622400 second [s] to 1 year (leap)
        /// </summary>
        public static double Second_2_YearLeap(double inVal)                            => inVal / 31622400;

        /// <summary>
        /// YearTropical -> s
        /// 1 year (tropical) to vv: 31556930 second [s]
        /// </summary>
        public static double YearTropical_2_Second(double inVal)                        => inVal * 31556930;
        /// <summary>
        /// s -> YearTropical
        /// vv: 31556930 second [s] to 1 year (tropical)
        /// </summary>
        public static double Second_2_YearTropical(double inVal)                        => inVal / 31556930;

        /// <summary>
        /// YearSidereal -> s
        /// 1 year (sidereal) to vv: 31558149.54 second [s]
        /// </summary>
        public static double YearSidereal_2_Second(double inVal)                        => inVal * 31558149.54;
        /// <summary>
        /// s -> YearSidereal
        /// vv: 31558149.54 second [s] to 1 year (sidereal)
        /// </summary>
        public static double Second_2_YearSidereal(double inVal)                        => inVal / 31558149.54;

        /// <summary>
        /// DaySidereal -> s
        /// 1 day (sidereal) to vv: 86164.09 second [s]
        /// </summary>
        public static double DaySidereal_2_Second(double inVal)                         => inVal * 86164.09;
        /// <summary>
        /// s -> DaySidereal
        /// vv: 86164.09 second [s] to 1 day (sidereal)
        /// </summary>
        public static double Second_2_DaySidereal(double inVal)                         => inVal / 86164.09;

        /// <summary>
        /// HourSidereal -> s
        /// 1 hour (sidereal) to vv: 3590.1704166667 second [s]
        /// </summary>
        public static double HourSidereal_2_Second(double inVal)                        => inVal * 3590.1704166667;
        /// <summary>
        /// s -> HourSidereal
        /// vv: 3590.1704166667 second [s] to 1 hour (sidereal)
        /// </summary>
        public static double Second_2_HourSidereal(double inVal)                        => inVal / 3590.1704166667;

        /// <summary>
        /// MinuteSidereal -> s
        /// 1 minute (sidereal) to vv: 59.8361736111 second [s]
        /// </summary>
        public static double MinuteSidereal_2_Second(double inVal)                      => inVal * 59.8361736111;
        /// <summary>
        /// s -> MinuteSidereal
        /// vv: 59.8361736111 second [s] to 1 minute (sidereal)
        /// </summary>
        public static double Second_2_MinuteSidereal(double inVal)                      => inVal / 59.8361736111;

        /// <summary>
        /// SecondSidereal -> s
        /// 1 second (sidereal) to vv: 0.9972695602 second [s]
        /// </summary>
        public static double SecondSidereal_2_Second(double inVal)                      => inVal * 0.9972695602;
        /// <summary>
        /// s -> SecondSidereal
        /// vv: 0.9972695602 second [s] to 1 second (sidereal)
        /// </summary>
        public static double Second_2_SecondSidereal(double inVal)                      => inVal / 0.9972695602;

        /// <summary>
        /// Fortnight -> s
        /// 1 fortnight to vv: 1209600 second [s]
        /// </summary>
        public static double Fortnight_2_Second(double inVal)                           => inVal * 1209600;
        /// <summary>
        /// s -> Fortnight
        /// vv: 1209600 second [s] to 1 fortnight
        /// </summary>
        public static double Second_2_Fortnight(double inVal)                           => inVal / 1209600;

        /// <summary>
        /// Septennial -> s
        /// 1 septennial to vv: 220752000 second [s]
        /// </summary>
        public static double Septennial_2_Second(double inVal)                          => inVal * 220752000;
        /// <summary>
        /// s -> Septennial
        /// vv: 220752000 second [s] to 1 septennial
        /// </summary>
        public static double Second_2_Septennial(double inVal)                          => inVal / 220752000;

        /// <summary>
        /// Octennial -> s
        /// 1 octennial to vv: 252288000 second [s]
        /// </summary>
        public static double Octennial_2_Second(double inVal)                           => inVal * 252288000;
        /// <summary>
        /// s -> Octennial
        /// vv: 252288000 second [s] to 1 octennial
        /// </summary>
        public static double Second_2_Octennial(double inVal)                           => inVal / 252288000;

        /// <summary>
        /// Novennial -> s
        /// 1 novennial to vv: 283824000 second [s]
        /// </summary>
        public static double Novennial_2_Second(double inVal)                           => inVal * 283824000;
        /// <summary>
        /// s -> Novennial
        /// vv: 283824000 second [s] to 1 novennial
        /// </summary>
        public static double Second_2_Novennial(double inVal)                           => inVal / 283824000;

        /// <summary>
        /// Quindecennial -> s
        /// 1 quindecennial to vv: 473040000 second [s]
        /// </summary>
        public static double Quindecennial_2_Second(double inVal)                       => inVal * 473040000;
        /// <summary>
        /// s -> Quindecennial
        /// vv: 473040000 second [s] to 1 quindecennial
        /// </summary>
        public static double Second_2_Quindecennial(double inVal)                       => inVal / 473040000;

        /// <summary>
        /// Quinquennial -> s
        /// 1 quinquennial to vv: 157680000 second [s]
        /// </summary>
        public static double Quinquennial_2_Second(double inVal)                        => inVal * 157680000;
        /// <summary>
        /// s -> Quinquennial
        /// vv: 157680000 second [s] to 1 quinquennial
        /// </summary>
        public static double Second_2_Quinquennial(double inVal)                        => inVal / 157680000;

        /// <summary>
        /// PlanckTime -> s
        /// 1 Planck time to vv: 5.39056E-44 second [s]
        /// </summary>
        public static double PlanckTime_2_Second(double inVal)                          => inVal * 5.39056E-44;
        /// <summary>
        /// s -> PlanckTime
        /// vv: 5.39056E-44 second [s] to 1 Planck time
        /// </summary>
        public static double Second_2_PlanckTime(double inVal)                          => inVal / 5.39056E-44;

    #endregion
    }
}
