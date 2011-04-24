using System;
using System.Collections.Generic;
using System.Text;
using Zutubi.Pulse.Api.Types;
using java.util;
using java.lang;

namespace Zutubi.Pulse.Api
{
    public static partial class Serializers
    {
        /// <summary>
        /// The method used to serialize a BuildResult from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized BuildResult</returns>
        public static BuildResult SerializeBuildResult(HashMap hm)
        {
            BuildResult br = new BuildResult();
            br.Completed = Convert.ToBool((java.lang.Boolean)hm.get("completed"));
            
            br.EndTime = Convert.ToDateTime((Date)hm.get("endTime"));
            br.EndTimeMillis = (string)hm.get("endTimeMillis");
            br.ErrorCount = Convert.ToInt32((Integer)hm.get("errorCount"));
            br.ID = Convert.ToInt32((Integer)hm.get("id"));
            br.Progress = Int32.Parse(((Integer)hm.get("progress")).toString());
            br.Reason = (string)hm.get("reason");
            br.Revision = (string)hm.get("revision");
            br.StartTime = Convert.ToDateTime((Date)hm.get("startTime"));
            br.StartTimeMillis = (string)hm.get("startTimeMillis");
            br.Status = (string)hm.get("status");
            br.WarningCount = Convert.ToInt32((Integer)hm.get("warningCount"));
            br.Stages = new List<StageResult>();
            foreach (System.Object hm2 in (System.Object[])hm.get("stages"))
            {
                br.Stages.Add(SerializeStageResult((HashMap)hm2));
            }
            HashMap hm3 = (HashMap)hm.get("tests");
            br.Tests = SerializeTestSummary(hm3);
            return br;
        }
    }
}
