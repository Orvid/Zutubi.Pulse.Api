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
        /// The method used to serialize a CommandResult from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized CommandResult</returns>
        public static CommandResult SerializeCommandResult(HashMap hm)
        {
            CommandResult cr = new CommandResult();
            cr.Completed = Convert.ToBool((java.lang.Boolean)hm.get("completed"));
            cr.EndTime = Convert.ToDateTime((Date)hm.get("endTime"));
            cr.ErrorCount = Convert.ToInt32((Integer)hm.get("errorCount"));
            cr.Name = (string)hm.get("name");
            cr.Progress = Convert.ToInt32((Integer)hm.get("progress"));
            cr.StartTime = Convert.ToDateTime((Date)hm.get("startTime"));
            cr.Status = (string)hm.get("status");
            cr.Succeeded = Convert.ToBool((java.lang.Boolean)hm.get("succeeded"));
            cr.WarningCount = Convert.ToInt32((Integer)hm.get("warningCount"));
            cr.Properties = SerializeCommandResultProperties((HashMap)hm.get("properties"));
            return cr;
        }
    }
}
