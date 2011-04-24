using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using java.lang;
using java.util;

namespace Zutubi.Pulse.Api
{
    public static partial class Convert
    {
        /// <summary>
        /// The method used to convert a java Date to a .net DateTime.
        /// </summary>
        /// <param name="dt">The Date to convert.</param>
        /// <returns>The Converted DateTime.</returns>
        public static DateTime ToDateTime(Date dt)
        {
            int year = dt.getYear();
            int month = dt.getMonth();
            int day = dt.getDay();
            int hour = dt.getHours();
            int minute = dt.getMinutes();
            int second = dt.getSeconds();
            DateTime dtm = new DateTime(year, month, day, hour, minute, second);
            return dtm;
        }
        /// <summary>
        /// The method used to convert a .net DateTime into a java Date.
        /// </summary>
        /// <param name="dtm">The DateTime to convert.</param>
        /// <returns>The converted Date.</returns>
        public static Date FromDateTime(DateTime dtm)
        {
            int year = dtm.Year;
            int month = dtm.Month;
            int day = dtm.Day;
            int hour = dtm.Hour;
            int minute = dtm.Minute;
            int second = dtm.Second;
            Date dt = new Date(year, month, day, hour, minute, second);
            return dt;
        }
    }
}
