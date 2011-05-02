using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;
using System.Runtime.InteropServices;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The BuildRequestStatus type holds information about the state of a build request, as returned by RemoteApi.getBuildRequestStatus and related functions.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BuildRequestStatus
    {
        /// <summary>
        /// Only valid when status is ASSIMILATED: the 64-bit id of the request that this request was assimilated into. 
        /// </summary>
        [XmlRpcMember("assimilatedId")]
        public String AssimilatedID;
        /// <summary>
        /// Only valid when status is ACTIVATED: the 64-bit build number for the build activated by this request. 
        /// </summary>
        [XmlRpcMember("buildId")]
        public String BuildID;
        /// <summary>
        /// Only valid when status is REJECTED: the reason that a request was rejected. 
        /// </summary>
        [XmlRpcMember("rejectionReason")]
        public String RejectionReason;
        /// <summary>
        /// The status of the request.
        /// </summary>
        [XmlRpcMember("status")]
        public RequestStatus Status;
    }
    /// <summary>
    /// The enum containing the possible Request Status's
    /// </summary>
    public enum RequestStatus
    {
        /// <summary>
        /// The request is unknown to the registry. 
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// The request is known, but has not yet reached the queue. 
        /// </summary>
        UNHANDLED,
        /// <summary>
        /// The request was rejected, possibly with a reason. 
        /// </summary>
        REJECTED,
        /// <summary>
        /// The request was assimilated into an existing queued request. 
        /// </summary>
        ASSIMILATED,
        /// <summary>
        /// The request has reached the queue and is awaiting activation. 
        /// </summary>
        QUEUED,
        /// <summary>
        /// The request was explicitly cancelled by a user. 
        /// </summary>
        CANCELLED,
        /// <summary>
        /// The request has been activated and now has a corresponding build number for further tracking.
        /// </summary>
        ACTIVATED
    }
}
