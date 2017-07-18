using System;
using System.Globalization;

namespace LibraryAPI
{
    public class DateTimeApp
    {
        /// <summary>
        /// Parses the date time in "yyyy-MM-dd_HH-mm-ss" format.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns></returns>
        public DateTime ParseDateTime(string dateTime)
        {
            return DateTime.ParseExact(dateTime, "yyyy-MM-dd_HH-mm-ss", CultureInfo.InvariantCulture, DateTimeStyles.None);
        }
    }
}
