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
        /// The method used to serialize a TestSummary from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized TestSummary</returns>
        public static TestSummary SerializeTestSummary(HashMap hm)
        {
            TestSummary ts = new TestSummary();
            ts.Errors = Convert.ToInt32((java.lang.Integer)hm.get("errors"));
            ts.ExpectedFailures = Convert.ToInt32((java.lang.Integer)hm.get("expectedFailures"));
            ts.Failures = Convert.ToInt32((java.lang.Integer)hm.get("failures"));
            ts.Passed = Convert.ToInt32((java.lang.Integer)hm.get("passed"));
            ts.Skipped = Convert.ToInt32((java.lang.Integer)hm.get("skipped"));
            ts.Total = Convert.ToInt32((java.lang.Integer)hm.get("total"));
            return ts;
        }
    }
}
