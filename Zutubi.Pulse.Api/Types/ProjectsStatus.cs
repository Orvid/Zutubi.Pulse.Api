using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using CookComputing.XmlRpc;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// A struct for the status of multiple projects.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ProjectsStatus
    {
        /// <summary>
        /// The timestamp of when this was requested.
        /// </summary>
        [XmlRpcMember("timestamp")]
        public string Timestamp;
        /// <summary>
        /// The projects.
        /// </summary>
        [XmlRpcMember("projects")]
        public ProjectStatus[] Projects;
        /// <summary>
        /// A (nullable) array of projects that are personal.
        /// </summary>
        [XmlRpcMember("personal")]
        public ProjectStatus? Personal;
    }
}
