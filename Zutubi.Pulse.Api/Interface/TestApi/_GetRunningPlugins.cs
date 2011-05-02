using System;
using System.Collections.Generic;
using System.Text;
using Zutubi.Pulse.Api.Types;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Plugin[] GetRunningPlugins()
        {
            CheckAuth(AuthType.Admin);
            return Client.GetRunningPlugins(authToken);
        }
    }
}
