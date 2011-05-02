using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;
using System.Runtime.InteropServices;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The Changelist type holds information about an SCM change that affected some build.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ChangeList
    {
        /// <summary>
        /// The revision of the changelist, e.g. a repository revision for Subversion.
        /// </summary>
        [XmlRpcMember("revision")]
        public String Revision;
        /// <summary>
        /// The user the submitted the changelist.
        /// </summary>
        [XmlRpcMember("author")]
        public String Author;
        /// <summary>
        /// The date at which the change was submitted (according to the SCM server clock).
        /// </summary>
        [XmlRpcMember("date")]
        public String Date;
        /// <summary>
        /// The comment provided by the author for the change.
        /// </summary>
        [XmlRpcMember("comment")]
        public String Comment;
        /// <summary>
        /// The files affected by the changelist.
        /// </summary>
        [XmlRpcMember("files")]
        public FileChange[] Files;
    }
}
