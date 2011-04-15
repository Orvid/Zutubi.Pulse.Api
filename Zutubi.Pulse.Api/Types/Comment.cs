using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The Comment type holds information about a single build comment.
    /// </summary>
    public struct Comment
    {
        /// <summary>
        /// A unique identified for the comment (64-bit integer converted to a string).
        /// </summary>
        public String ID;
        /// <summary>
        /// Login of the user that added the comment.
        /// </summary>
        public String Author;
        /// <summary>
        /// The content of the comment.
        /// </summary>
        public String Message;
        /// <summary>
        /// The time that the comment was added, in milliseconds since the epoch (UTC), converted to a string.
        /// </summary>
        public String Time;
    }
}
