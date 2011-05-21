using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using CookComputing.XmlRpc;
using System.ComponentModel;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The BuildResult type holds the result of a single project build.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BuildResult
    {
        /// <summary>
        /// The build identifier or number of the build.
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 ID;
        /// <summary>
        /// True if the build has completed.
        /// </summary>
        [XmlRpcMember("endTime")]
        public DateTime EndTime;
        /// <summary>
        /// The time that the build completed, in milliseconds since the epoch (UTC),
        /// converted to a string. Not valid if completed is false.
        /// </summary>
        [XmlRpcMember("endTimeMillis")]
        public String EndTimeMillis;
        /// <summary>
        /// The number of error features found in the build.
        /// </summary>
        [XmlRpcMember("errorCount")]
        public int ErrorCount;
        /// <summary>
        /// The estimated percentage complete for the build [0-100]. Set to -1 if no estimate has been made.
        /// </summary>
        [XmlRpcMember("progress")]
        public int Progress;
        /// <summary>
        /// The revision for the build, which may be an empty string if the build failed before a revision was determined.
        /// </summary>
        [XmlRpcMember("revision")]
        public String Revision;
        /// <summary>
        /// A human readable string describing the reason this build was triggered.
        /// </summary>
        [XmlRpcMember("reason")]
        public String Reason;
        /// <summary>
        /// The build stages executed for this build.
        /// </summary>
        [XmlRpcMember("stages")]
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public StageResult?[] Stages;
        /// <summary>
        /// The time that the build commenced, not valid in state pending.
        /// </summary>
        [XmlRpcMember("startTime")]
        public DateTime StartTime;
        /// <summary>
        /// The time that the build commenced, in milliseconds since the epoch (UTC), converted to a string.
        /// </summary>
        [XmlRpcMember("startTimeMillis")]
        public String StartTimeMillis;
        /// <summary>
        /// The state of the build. See Build States.
        /// </summary>
        [XmlRpcMember("status")]
        public BuildStatus Status;
        /// <summary>
        /// A summary of all tests run in the build.
        /// </summary>
        [XmlRpcMember("tests")]
        public TestSummary Tests;
        /// <summary>
        /// True if the build has completed and succeeded.
        /// </summary>
        [XmlRpcMember("completed")]
        public Boolean Completed;
        /// <summary>
        /// The number of warning features found in the build.
        /// </summary>
        [XmlRpcMember("warningCount")]
        public int WarningCount;
    }
    /// <summary>
    /// The enum that contains the possible build status's.
    /// </summary>
    public enum BuildStatus
    {
        /// <summary>
        /// The pending build status. 
        /// This means that the build is pending.
        /// </summary>
        Pending,
        /// <summary>
        /// The in progress build status.
        /// This means that the build is currently in progress.
        /// </summary>
        In_Progress,
        /// <summary>
        /// The terminating build status.
        /// This means that the build is currently terminating.
        /// </summary>
        Terminating,
        /// <summary>
        /// The terminated build status.
        /// This means that the build was terminated.
        /// </summary>
        Terminated,
        /// <summary>
        /// The success build status.
        /// This means that the build was successful.
        /// </summary>
        Success,
        /// <summary>
        /// The failure build status.
        /// This means that the build failed.
        /// </summary>
        Failure,
        /// <summary>
        /// The error build status.
        /// This means that there are errors in the build.
        /// </summary>
        Error
    }
}