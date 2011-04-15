using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The BuildResult type holds the result of a single project build.
    /// </summary>
    public struct BuildResult
    {
        /// <summary>
        /// The build identifier or number of the build.
        /// </summary>
        public String ID;
        /// <summary>
        /// True if the build has completed.
        /// </summary>
        public DateTime EndTime;
        /// <summary>
        /// The time that the build completed, in milliseconds since the epoch (UTC),
        /// converted to a string. Not valid if completed is false.
        /// </summary>
        public String EndTimeMillis;
        /// <summary>
        /// The number of error features found in the build.
        /// </summary>
        public int ErrorCount;
        /// <summary>
        /// The estimated percentage complete for the build [0-100]. Set to -1 if no estimate has been made.
        /// </summary>
        public int Progress;
        /// <summary>
        /// The revision for the build, which may be an empty string if the build failed before a revision was determined.
        /// </summary>
        public String Revision;
        /// <summary>
        /// A human readable string describing the reason this build was triggered.
        /// </summary>
        public String Reason;
        /// <summary>
        /// The build stages executed for this build.
        /// </summary>
        public List<StageResult> Stages;
        /// <summary>
        /// The time that the build commenced, not valid in state pending.
        /// </summary>
        public DateTime StartTime;
        /// <summary>
        /// The time that the build commenced, in milliseconds since the epoch (UTC), converted to a string.
        /// </summary>
        public String StartTimeMillis;
        /// <summary>
        /// The state of the build, one of {pending, in progress, terminating, success, failure, error}. See Build States.
        /// </summary>
        public String Status;
        /// <summary>
        /// A summary of all tests run in the build.
        /// </summary>
        public TestSummary Tests;
        /// <summary>
        /// True if the build has completed and succeeded.
        /// </summary>
        public Boolean Completed;
        /// <summary>
        /// The number of warning features found in the build.
        /// </summary>
        public int WarningCount;

    }
}
