using System;
using System.Collections.Generic;
using System.Text;
using Zutubi.Pulse.Api.Types;
using java.util;

namespace Zutubi.Pulse.Api
{
    /// <summary>
    /// The class that contains all of the serializers for the various structs.
    /// </summary>
    public static partial class Serializers
    {
        /// <summary>
        /// The method used to serialize an Artifact from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized Artifact</returns>
        public static Artifact SerializeArtifact(HashMap hm)
        {
            Artifact a = new Artifact();
            a.Command = (string)hm.get("command");
            a.Name = (string)hm.get("name");
            a.PermaLink = (string)hm.get("permaLink");
            a.Stage = (string)hm.get("stage");

            return a;
        }
    }
}
