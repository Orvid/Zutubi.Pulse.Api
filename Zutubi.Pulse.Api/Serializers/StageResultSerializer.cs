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
        /// The method used to serialize a StageResult from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized StageResult</returns>
        public static StageResult SerializeStageResult(HashMap hm)
        {
            StageResult sr = new StageResult();
            sr.Agent = (string)hm.get("agent");
            sr.Completed = (Boolean)hm.get("completed");
            sr.EndTime = DateTime.Parse(((Date)hm.get("endTime")).toString());
            sr.ErrorCount = (int)hm.get("errorCount");
            sr.Name = (string)hm.get("name");
            sr.Progress = (int)hm.get("progress");
            sr.StartTime = DateTime.Parse(((Date)hm.get("startTime")).toString());
            sr.Status = (string)hm.get("status");
            sr.Succeeded = (bool)hm.get("succeeded");
            sr.WarningCount = (int)hm.get("warningCount");
            HashMap hm2 = (HashMap)hm.get("commands");
            sr.Commands = SerializeCommandResult(hm2);
            HashMap hm3 = (HashMap)hm.get("tests");
            sr.Tests = SerializeTestSummary(hm3);
            return sr;
        }
    }
}
