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
            sr.Completed = Boolean.Parse(((java.lang.Boolean)hm.get("completed")).toString());
            //sr.EndTime = DateTime.Parse(((Date)hm.get("endTime")).toString());
            sr.ErrorCount = Int32.Parse(((java.lang.Integer)hm.get("errorCount")).toString());
            sr.Name = (string)hm.get("name");
            sr.Progress = Int32.Parse(((java.lang.Integer)hm.get("progress")).toString());
            //sr.StartTime = DateTime.Parse(((Date)hm.get("startTime")).toString());
            sr.Status = (string)hm.get("status");
            sr.Succeeded = Boolean.Parse(((java.lang.Boolean)hm.get("succeeded")).toString());
            sr.WarningCount = Int32.Parse(((java.lang.Integer)hm.get("warningCount")).toString());
            Object[] hm2 = (Object[])hm.get("commands");
            foreach(Object o in hm2)
            {
                sr.Commands = SerializeCommandResult((HashMap)o);
            }
            HashMap hm3 = (HashMap)hm.get("tests");
            sr.Tests = SerializeTestSummary(hm3);
            return sr;
        }
    }
}
