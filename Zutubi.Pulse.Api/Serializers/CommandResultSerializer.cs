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
        /// The method used to serialize a CommandResult from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized CommandResult</returns>
        public static CommandResult SerializeCommandResult(HashMap hm)
        {
            CommandResult cr = new CommandResult();
            cr.Completed = (bool)hm.get("completed");
            cr.EndTime = DateTime.Parse(((Date)hm.get("endTime")).toString());
            cr.ErrorCount = (int)hm.get("errorCount");
            cr.Name = (string)hm.get("name");
            cr.Progress = (int)hm.get("progress");
            cr.StartTime = DateTime.Parse(((Date)hm.get("startTime")).toString());
            cr.Status = (string)hm.get("status");
            cr.Succeeded = (bool)hm.get("succeeded");
            cr.WarningCount = (int)hm.get("warningCount");
            cr.Properties = SerializeCommandResultProperties((HashMap)hm.get("properties"));
            return cr;
        }
    }
}
