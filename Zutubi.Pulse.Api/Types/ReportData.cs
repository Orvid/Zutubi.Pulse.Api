using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The ReportData type holds data generated from a project 
    /// report configuration applied to a set of build results. 
    /// Reports are broken down into multiple series, represented
    /// by the <seealso cref="ReportSeries">ReportSeries</seealso> type.
    /// </summary>
    public struct ReportData
    {
        /// <summary>
        /// The name of the report. 
        /// </summary>
        public String Name;
        /// <summary>
        /// A list of series data structs containing the data for each series in the report. 
        /// </summary>
        public List<ReportSeries> Series;
    }
}
