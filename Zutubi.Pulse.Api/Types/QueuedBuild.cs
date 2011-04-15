using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The QueuedBuild type holds information about a queued build request.
    /// </summary>
    public struct QueuedBuild
    {
        /// <summary>
        /// Unique identifier of the request, useful if you need to cancel it. 
        /// </summary>
        public String ID;
        /// <summary>
        /// Name of the project that will be built. 
        /// </summary>
        public String Project;
        /// <summary>
        /// Name of the request owner: either the project name (for project builds) or the user login (for personal builds). 
        /// </summary>
        public String Owner;
        /// <summary>
        /// True if the request is for a personal build, false otherwise. 
        /// </summary>
        public Boolean IsPersonal;
        /// <summary>
        /// Indicates the source of the request, e.g. "remote api". 
        /// </summary>
        public String RequestSource;
        /// <summary>
        /// True if this request can be replaced by other requests that have the same request source. 
        /// </summary>
        public Boolean IsReplaceable;
        /// <summary>
        /// The time, in milliseconds since the epoch (UTC), that this request was added to the queue (converted to a string as it is a 64-bit value). 
        /// </summary>
        public String QueuedTime;
        /// <summary>
        /// The reason for this request (becomes the build reason). 
        /// </summary>
        public String Reason;
        /// <summary>
        /// The revision to build if it has been fixed, or the empty string if the revision is floating. 
        /// </summary>
        public String Revision;
    }
}
