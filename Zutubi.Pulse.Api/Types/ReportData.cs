using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;
using System.Runtime.InteropServices;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The ReportData type holds data generated from a project 
    /// report configuration applied to a set of build results. 
    /// Reports are broken down into multiple series, represented
    /// by the <seealso cref="ReportSeries">ReportSeries</seealso> type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ReportData
    {
        /// <summary>
        /// The name of the report. 
        /// </summary>
        [XmlRpcMember("name")]
        public String Name;
        /// <summary>
        /// A list of series data structs containing the data for each series in the report. 
        /// </summary>
        [XmlRpcMember("series")]
        public List<ReportSeries> Series;
    }
}
