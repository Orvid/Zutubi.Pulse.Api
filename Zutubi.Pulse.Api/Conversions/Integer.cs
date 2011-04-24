using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using java.lang;

namespace Zutubi.Pulse.Api
{
    public static partial class Convert
    {
        /// <summary>
        /// The conversion method to convert a java Integer to a .net Int32
        /// </summary>
        /// <param name="intg">The Integer to convert.</param>
        /// <returns>The converted Int32.</returns>
        public static Int32 ToInt32(Integer intg)
        {
            string str = intg.toString();
            Int32 nt = Int32.Parse(str);
            return nt;
        }
        /// <summary>
        /// The conversion method to convert a .net Int32 to a java Integer.
        /// </summary>
        /// <param name="intg">The Int32 to convert.</param>
        /// <returns>The converted Integer.</returns>
        public static Integer FromInt32(Int32 intg)
        {
            string str = intg.ToString();
            Integer nt = Integer.getInteger(str);
            return nt;
        }
    }
}
