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
        /// The method used to serialize a BuildResult from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized BuildResult</returns>
        public static BuildResult SerializeBuildResult(HashMap hm)
        {
            BuildResult br = new BuildResult();
            br.Completed = (bool)hm.get("completed");
            
            br.EndTime = DateTime.Parse(((Date)hm.get("endTime")).toString());
            br.EndTimeMillis = (string)hm.get("endTimeMillis");
            br.ErrorCount = (int)hm.get("errorCount");
            br.ID = (string)hm.get("id");
            br.Progress = (int)hm.get("progress");
            br.Reason = (string)hm.get("reason");
            br.Revision = (string)hm.get("revision");
            br.StartTime = DateTime.Parse(((Date)hm.get("startTime")).toString());
            br.StartTimeMillis = (string)hm.get("startTimeMillis");
            br.Status = (string)hm.get("status");
            br.WarningCount = (int)hm.get("warningCount");
            foreach (HashMap hm2 in (HashMap[])hm.get("stages"))
            {
                br.Stages.Add(SerializeStageResult(hm2));
            }
            HashMap hm3 = (HashMap)hm.get("tests");
            br.Tests = SerializeTestSummary(hm3);
            return br;
        }
    }
}
