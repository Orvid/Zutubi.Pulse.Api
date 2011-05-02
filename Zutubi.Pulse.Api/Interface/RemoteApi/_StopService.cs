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
        public static bool StopService()
        {
            CheckAuth(AuthType.Admin);
            return Client.StopService(authToken);
        }
    }
}
