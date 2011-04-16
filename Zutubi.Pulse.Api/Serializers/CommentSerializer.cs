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
        /// The method used to serialize a Comment from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized Comment</returns>
        public static Comment SerializeComment(HashMap hm)
        {
            Comment c = new Comment();
            c.Author = (string)hm.get("author");
            c.ID = (string)hm.get("id");
            c.Message = (string)hm.get("message");
            c.Time = (string)hm.get("time");
            return c;
        }
    }
}
