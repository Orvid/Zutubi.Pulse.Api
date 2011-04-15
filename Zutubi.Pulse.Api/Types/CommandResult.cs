using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The CommandResult type holds the result of a command executed as part of a build stage. 
    /// </summary>
    public struct CommandResult
    {
        /// <summary>
        /// True if, and only if, the stage has completed.
        /// </summary>
        public bool Completed;
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
        /// The state of the stage, one of {pending, in progress, terminating, success, failure, error}. See Build States.
        /// </summary>
        public String Status;
        /// <summary>
        /// True if, and only if, the stage has compeleted and succeeded.
        /// </summary>
        public Boolean Succeeded;
        /// <summary>
        /// A summary of the details associated with this command.
        /// </summary>
        public CommandResultProperties Properties;
        /// <summary>
        /// The number of warning features found in the stage.
        /// </summary>
        public int WarningCount;
    }
}
