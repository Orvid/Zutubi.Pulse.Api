using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;
using System.Runtime.InteropServices;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The StageResult type holds the result of a build stage executed as part of a build.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct StageResult
    {
        /// <summary>
        /// Name of the agent that the stage ran on, may be "[pending]" if the stage never reached an agent.
        /// </summary>
        [XmlRpcMember("agent")]
        public String Agent;
        /// <summary>
        /// True if, and only if, the stage has completed.
        /// </summary>
        [XmlRpcMember("completed")]
        public Boolean Completed;
        /// <summary>
        /// The time that the stage completed, not valid if completed is false.
        /// </summary>
        [XmlRpcMember("endTime")]
        public DateTime EndTime;
        /// <summary>
        /// The number of error features found in the stage.
        /// </summary>
        [XmlRpcMember("errorCount")]
        public int ErrorCount;
        /// <summary>
        /// Name of the stage.
        /// </summary>
        [XmlRpcMember("name")]
        public String Name;
        /// <summary>
        /// The estimated percentage complete for the stage [0-100]. Set to -1 if no estimate has been made.
        /// </summary>
        [XmlRpcMember("progress")]
        public int Progress;
        /// <summary>
        /// The time that the stage commenced, not valid in state pending.
        /// </summary>
        [XmlRpcMember("startTime")]
        public DateTime StartTime;
        /// <summary>
        /// The state of the stage, one of {pending, in progress, terminating, success, failure, error}.
        /// </summary>
        [XmlRpcMember("status")]
        public String Status;
        /// <summary>
        /// True if, and only if, the stage has compeleted and succeeded.
        /// </summary>
        [XmlRpcMember("succeeded")]
        public Boolean Succeeded;
        /// <summary>
        /// A summary of all tests run in the stage.
        /// </summary>
        [XmlRpcMember("tests")]
        public TestSummary Tests;
        /// <summary>
        /// A summary of all commands run in the stage.
        /// </summary>
        [XmlRpcMember("commands")]
        public CommandResult[] Commands;
        /// <summary>
        /// The number of warning features found in the stage.
        /// </summary>
        [XmlRpcMember("warningCount")]
        public int WarningCount;
    }
}
