using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The ReportSeries type holds data generated for
    /// a single series of a larger <seealso cref="ReportData">ReportData</seealso>
    /// struct. The series data is packed into two parallel lists, which can be
    /// viewed as a single list of (label, value) points by pairing entries
    /// at the same index in each list.
    /// </summary>
    public struct ReportSeries
    {
        /// <summary>
        /// The name of the series. 
        /// </summary>
        public String Name;
        /// <summary>
        /// A list of labels, or domain (x) axis values
        /// that apply to the corresponding points. The 
        /// labels are 64-bit integers converted to strings.
        /// For reports that use days as the domain unit, 
        /// these integers are timestamps in milliseconds 
        /// since the epoch (UTC), marking midnight of the
        /// day that the data point corresponds to. 
        /// </summary>
        public List<String> Labels;
        /// <summary>
        /// A list of values, or range (y) axis values for each of the corresponding labels. 
        /// </summary>
        public List<Double> Values;
    }
}
