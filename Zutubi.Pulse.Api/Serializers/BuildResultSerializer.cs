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
            br.Completed = Convert.ToBoolean(hm.get("completed").ToString());
            
            //br.EndTime = DateTime.Parse(((Date)hm.get("endTime")).toString());
            br.EndTimeMillis = (string)hm.get("endTimeMillis");
            br.ErrorCount = Int32.Parse(((java.lang.Integer)hm.get("errorCount")).toString());
            br.ID = (string)((java.lang.Integer)hm.get("id")).toString();
            br.Progress = Int32.Parse(((java.lang.Integer)hm.get("progress")).toString());
            br.Reason = (string)hm.get("reason");
            br.Revision = (string)hm.get("revision");
            //br.StartTime = DateTime.Parse(((Date)hm.get("startTime")).toString());
            br.StartTimeMillis = (string)hm.get("startTimeMillis");
            br.Status = (string)hm.get("status");
            br.WarningCount = Int32.Parse(((java.lang.Integer)hm.get("warningCount")).toString());
            br.Stages = new List<StageResult>();
            foreach (Object hm2 in (Object[])hm.get("stages"))
            {
                br.Stages.Add(SerializeStageResult((HashMap)hm2));
            }
            HashMap hm3 = (HashMap)hm.get("tests");
            br.Tests = SerializeTestSummary(hm3);
            return br;
        }
    }
}
