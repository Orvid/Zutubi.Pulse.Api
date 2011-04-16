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
            ts.Errors = (int)hm.get("errors");
            ts.ExpectedFailures = (int)hm.get("expectedFailures");
            ts.Failures = (int)hm.get("failures");
            ts.Passed = (int)hm.get("passed");
            ts.Skipped = (int)hm.get("skipped");
            ts.Total = (int)hm.get("total");
            return ts;
        }
    }
}
