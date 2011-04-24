using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using java.lang;

namespace Zutubi.Pulse.Api
{
    /// <summary>
    /// The base class that contains all of the conversion methods.
    /// </summary>
    public static partial class Convert
    {
        /// <summary>
        /// The method used to convert a java Boolean into a .net bool.
        /// </summary>
        /// <param name="bln">The java Boolean to convert.</param>
        /// <returns>The converted bool.</returns>
        public static bool ToBool(java.lang.Boolean bln)
        {
            bool bl;
            string str = bln.toString();
            if (str.ToLowerInvariant() == "true")
            {
                bl = true;
            }
            else if (str.ToLowerInvariant() == "false")
            {
                bl = false;
            }
            else
            {
                throw new System.Exception("Invalid Boolean Format!");
            }
            return bl;
        }
        /// <summary>
        /// The method used to convert a .net bool into a java Boolean.
        /// </summary>
        /// <param name="bln">The .net bool to convert.</param>
        /// <returns>The converted Boolean.</returns>
        public static java.lang.Boolean FromBoolean(bool bln)
        {
            java.lang.Boolean bl;
            string str = bln.ToString();
            if (str.ToLowerInvariant() == "true")
            {
                bl = java.lang.Boolean.TRUE;
            }
            else if (str.ToLowerInvariant() == "false")
            {
                bl = java.lang.Boolean.FALSE;
            }
            else
            {
                throw new System.Exception("Invalid Boolean Format!");
            }
            return bl;
        }
    }
}
