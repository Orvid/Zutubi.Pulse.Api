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
        /// The method used to serialize a QueuedBuild from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized QueuedBuild</returns>
        public static QueuedBuild SerializeQueuedBuild(HashMap hm)
        {
            QueuedBuild qb = new QueuedBuild();
            qb.ID = (string)hm.get("id");
            qb.IsPersonal = Convert.ToBool((java.lang.Boolean)hm.get("isPersonal"));
            qb.IsReplaceable = Convert.ToBool((java.lang.Boolean)hm.get("isReplaceable"));
            qb.Owner = (string)hm.get("owner");
            qb.Project = (string)hm.get("project");
            qb.QueuedTime = (string)hm.get("queuedTime");
            qb.Reason = (string)hm.get("reason");
            qb.RequestSource = (string)hm.get("requestSource");
            qb.Revision = (string)hm.get("revision");
            return qb;
        }
    }
}
