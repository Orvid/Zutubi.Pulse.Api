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
            ts.Errors = Int32.Parse(((java.lang.Integer)hm.get("errors")).toString());
            ts.ExpectedFailures = Int32.Parse(((java.lang.Integer)hm.get("expectedFailures")).toString());
            ts.Failures = Int32.Parse(((java.lang.Integer)hm.get("failures")).toString());
            ts.Passed = Int32.Parse(((java.lang.Integer)hm.get("passed")).toString());
            ts.Skipped = Int32.Parse(((java.lang.Integer)hm.get("skipped")).toString());
            ts.Total = Int32.Parse(((java.lang.Integer)hm.get("total")).toString());
            return ts;
        }
    }
}
