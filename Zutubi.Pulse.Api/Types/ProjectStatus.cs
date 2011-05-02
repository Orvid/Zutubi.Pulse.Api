using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using CookComputing.XmlRpc;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// A struct that describes the status of a project.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ProjectStatus
    {
        /// <summary>
        /// The owner of the project.
        /// </summary>
        [XmlRpcMember("owner")]
        public string Owner;
        /// <summary>
        /// The last completed build.
        /// </summary>
        [XmlRpcMember("latestCompleted")]
        public BuildResult? LatestCompleted;
        /// <summary>
        /// The builds that are currently in progress.
        /// </summary>
        [XmlRpcMember("inProgress")]
        public BuildResult[] InProgress;
        /// <summary>
        /// THE USAGE OF THIS IS UNKNOWN.
        /// </summary>
        [XmlRpcMember("completedSince")]
        public BuildResult[] CompletedSince;
        /// <summary>
        /// The health of the project.
        /// </summary>
        [XmlRpcMember("health")]
        public Health Health;
    }
    /// <summary>
    /// The enum used to display the health of a project.
    /// </summary>
    public enum Health
    {
        /// <summary>
        /// The health was unable to be determined.
        /// (This is not a good sign)
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// The project is building just fine.
        /// </summary>
        OK,
        /// <summary>
        /// The project builds, but there are multiple warnings.
        /// </summary>
        WARNINGS,
        /// <summary>
        /// The project is Broken, and does not build.
        /// </summary>
        BROKEN
    }
}
