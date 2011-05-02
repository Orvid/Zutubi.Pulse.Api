using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CookComputing.XmlRpc;
using System.Runtime.InteropServices;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The TestSummary type holds a summary of test status counts for a build or stage.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct TestSummary
    {
        /// <summary>
        /// The total number of test cases found. 
        /// </summary>
        [XmlRpcMember("total")]
        public int Total;
        /// <summary>
        /// The number of test cases in the error state. 
        /// </summary>
        [XmlRpcMember("errors")]
        public int Errors;
        /// <summary>
        /// The number of test cases in the expected failure state.
        /// </summary>
        [XmlRpcMember("expectedFailures")]
        public int ExpectedFailures;
        /// <summary>
        /// The number of test cases that failed. 
        /// </summary>
        [XmlRpcMember("failures")]
        public int Failures;
        /// <summary>
        /// The number of test cases that passed. 
        /// </summary>
        [XmlRpcMember("passed")]
        public int Passed;
        /// <summary>
        /// The number of test cases that were skipped.
        /// </summary>
        [XmlRpcMember("skipped")]
        public int Skipped;
    }
}