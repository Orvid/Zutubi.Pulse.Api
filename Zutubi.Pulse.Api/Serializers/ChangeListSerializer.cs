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
        public static ChangeList SerializeChangeList(HashMap hm)
        {
            ChangeList cl = new ChangeList();
            cl.Author = (string)hm.get("author");
            cl.Comment = (string)hm.get("comment");
            cl.Date = (string)hm.get("date");
            cl.Revision = (string)hm.get("revision");
            foreach (HashMap hm2 in (HashMap[])hm.get("files"))
            {
                cl.Files.Add(SerializeFileChange(hm2));
            }
            return cl;
        }
    }
}
