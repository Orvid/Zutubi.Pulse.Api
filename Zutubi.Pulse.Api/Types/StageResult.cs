using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The StageResult type holds the result of a build stage executed as part of a build.
    /// </summary>
    public struct StageResult
    {
        /// <summary>
        /// Name of the agent that the stage ran on, may be "[pending]" if the stage never reached an agent.
        /// </summary>
        public String Agent;
        /// <summary>
        /// True if, and only if, the stage has completed.
        /// </summary>
        public Boolean Completed;
        /// <summary>
        /// The time that the stage completed, not valid if completed is false.
        /// </summary>
        public DateTime EndTime;
        /// <summary>
        /// The number of error features found in the stage.
        /// </summary>
        public int ErrorCount;
        /// <summary>
        /// Name of the stage.
        /// </summary>
        public String Name;
        /// <summary>
        /// The estimated percentage complete for the stage [0-100]. Set to -1 if no estimate has been made.
        /// </summary>
        public int Progress;
        /// <summary>
        /// The time that the stage commenced, not valid in state pending.
        /// </summary>
        public DateTime StartTime;
        /// <summary>
        /// The state of the stage, one of {pending, in progress, terminating, success, failure, error}.
        /// </summary>
        public String Status;
        /// <summary>
        /// True if, and only if, the stage has compeleted and succeeded.
        /// </summary>
        public Boolean Succeeded;
        /// <summary>
        /// A summary of all tests run in the stage.
        /// </summary>
        public TestSummary Tests;
        /// <summary>
        /// A summary of all commands run in the stage.
        /// </summary>
        public CommandResult Commands;
        /// <summary>
        /// The number of warning features found in the stage.
        /// </summary>
        public int WarningCount;
    }
}
