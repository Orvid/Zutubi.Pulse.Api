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
        /// The method used to serialize a CommandResultProperties from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized CommandResultProperties</returns>
        public static CommandResultProperties SerializeCommandResultProperties(HashMap hm)
        {
            CommandResultProperties crp = new CommandResultProperties();
            string[] vla = (string[])hm.values().toArray();
            string[] kya = (string[])hm.keySet().toArray();
            int nmb = 0;
            while (nmb < vla.Length)
            {
                NameValuePair nvp = new NameValuePair();
                nvp.Name = kya[nmb];
                nvp.Value = vla[nmb];
                crp.Add(nvp);
            }
            return crp;
        }
    }
}
