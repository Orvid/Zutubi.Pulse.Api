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
        /// The method used to serialize a ReportSeries from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized ReportSeries</returns>
        public static ReportSeries SerializeReportSeries(HashMap hm)
        {
            ReportSeries rs = new ReportSeries();
            rs.Labels = new List<string>((string[])hm.get("labels"));
            rs.Name = (string)hm.get("name");
            rs.Values = new List<double>((double[])hm.get("values"));
            return rs;
        }
    }
}
