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
        /// The method used to serialize a Feature from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized Feature</returns>
        public static Feature SerializeFeature(HashMap hm)
        {
            Feature f = new Feature();
            f.Artifact = (string)hm.get("artifact");
            f.Command = (string)hm.get("command");
            f.Level = (FeatureLevel)Enum.Parse(typeof(FeatureLevel), (string)hm.get("level"), true);
            f.Message = (string)hm.get("message");
            f.Path = (string)hm.get("path");
            f.Stage = (string)hm.get("stage");
            return f;
        }
    }
}
