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
        /// The method used to serialize a FileChange from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized FileChange</returns>
        public static FileChange SerializeFileChange(HashMap hm)
        {
            FileChange fc = new FileChange();
            fc.Action = (FileChangeAction)Enum.Parse(typeof(FileChangeAction), ((string)hm.get("action")), true);
            fc.File = (string)hm.get("file");
            fc.Revision = (string)hm.get("revision");
            return fc;
        }
    }
}
