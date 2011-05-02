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
        /// <returns></returns>
        public static bool CancelActiveBuilds()
        {
            CheckAuth(AuthType.Admin);
            return Client.CancelActiveBuilds(authToken);
        }
    }
}
