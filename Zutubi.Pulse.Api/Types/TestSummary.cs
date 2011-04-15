using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The TestSummary type holds a summary of test status counts for a build or stage.
    /// </summary>
    public struct TestSummary
    {
        /// <summary>
        /// The total number of test cases found. 
        /// </summary>
        public int Total;
        /// <summary>
        /// The number of test cases in the error state. 
        /// </summary>
        public int Errors;
        /// <summary>
        /// The number of test cases in the expected failure state.
        /// </summary>
        public int ExpectedFailures;
        /// <summary>
        /// The number of test cases that failed. 
        /// </summary>
        public int Failures;
        /// <summary>
        /// The number of test cases that passed. 
        /// </summary>
        public int Passed;
        /// <summary>
        /// The number of test cases that were skipped.
        /// </summary>
        public int Skipped;
    }
}
