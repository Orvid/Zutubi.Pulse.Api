using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pluginJar"></param>
        /// <returns></returns>
        public static bool InstallPlugin(string pluginJar)
        {
            CheckAuth(AuthType.Admin);
            return Client.InstallPlugin(authToken, pluginJar);
        }
    }
}
