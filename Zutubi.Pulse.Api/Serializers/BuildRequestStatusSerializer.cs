using System;
using System.Collections.Generic;
using System.Text;
using Zutubi.Pulse.Api.Types;
using java.util;

namespace Zutubi.Pulse.Api
{
    public static partial class Serializers
    {
        /// <summary>
        /// The method used to serialize a BuildRequestStatus from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized BuildRequestStatus</returns>
        public static BuildRequestStatus SerializeBuildRequestStatus(HashMap hm)
        {
            BuildRequestStatus brs = new BuildRequestStatus();
            brs.Status = (RequestStatus)Enum.Parse(typeof(RequestStatus), (string)hm.get("status"), true);
            if (brs.Status == RequestStatus.ACTIVATED)
            {
                brs.BuildID = (string)hm.get("buildId");
                brs.AssimilatedID = "INVALID";
                brs.RejectionReason = "INVALID";
            }
            else if (brs.Status == RequestStatus.ASSIMILATED)
            {
                brs.BuildID = "INVALID";
                brs.AssimilatedID = (string)hm.get("assimilatedId");
                brs.RejectionReason = "INVALID";
            }
            else if (brs.Status == RequestStatus.REJECTED)
            {
                brs.BuildID = "INVALID";
                brs.AssimilatedID = "INVALID";
                brs.RejectionReason = (string)hm.get("rejectionReason");
            }
            else
            {
                brs.BuildID = "INVALID";
                brs.AssimilatedID = "INVALID";
                brs.RejectionReason = "INVALID";
            }
            return brs;
        }
    }
}
