
using System;

namespace StoneageTools.Date
{
    public static class StoneageToolsDate
    {
        public static DateTime GetTomorrow()                => DateTime.Today.AddDays(1);

        public static DateTime GetYesterday()               => DateTime.Today.AddDays(-1);

        public static DateTime GetToday()                   => DateTime.Today;

        public static DateTime GetFirstDayOfYear(DateTime y)   => new (y.Year, 1, 1);

        public static DateTime GetLastDayOfYear(DateTime y)
        {
            DateTime n = new(y.Year + 1, 1, 1);
            return n.AddDays(-1);
        }

        /// <summary>
        /// Checks if a string contains a valid date format
        /// </summary>
        /// <param name="value"></param>
        /// <returns>bool</returns>
        public static bool IsThisADate(this string value)   => DateTime.TryParse(value, out _);

        /// <summary>
        /// Check if a string contains a date format and makes it formatted readable
        /// </summary>
        /// <param name="value"></param>
        /// <returns>DateTime or Null</returns>
        public static DateTime WhatDateIsThis(this string value)
        {
            DateTime retVal = new();
            if (IsThisADate(value))
            {
                _ = DateTime.TryParse(value, out retVal);
            }
            return retVal;
        }
    }
}
