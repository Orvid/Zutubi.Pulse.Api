using System;
using System.Collections.Generic;
using System.Text;
using Zutubi.Pulse.Api.Types;
using java.util;

namespace Zutubi.Pulse.Api
{
    public static partial class Serializers
    {

        /// <summary>
        /// The method used to serialize a ReportData from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized ReportData</returns>
        public static ReportData SerializeReportData(HashMap hm)
        {
            ReportData rd = new ReportData();
            rd.Name = (string)hm.get("name");
            foreach (HashMap hm2 in (HashMap[])hm.get("series"))
            {
                rd.Series.Add(SerializeReportSeries(hm2));
            }
            return rd;
        }
    }
}
