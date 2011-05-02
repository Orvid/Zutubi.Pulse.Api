using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;
using System.Runtime.InteropServices;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The Comment type holds information about a single build comment.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Comment
    {
        /// <summary>
        /// A unique identified for the comment (64-bit integer converted to a string).
        /// </summary>
        [XmlRpcMember("id")]
        public String ID;
        /// <summary>
        /// Login of the user that added the comment.
        /// </summary>
        [XmlRpcMember("author")]
        public String Author;
        /// <summary>
        /// The content of the comment.
        /// </summary>
        [XmlRpcMember("message")]
        public String Message;
        /// <summary>
        /// The time that the comment was added, in milliseconds since the epoch (UTC), converted to a string.
        /// </summary>
        [XmlRpcMember("time")]
        public String Time;
    }
}
