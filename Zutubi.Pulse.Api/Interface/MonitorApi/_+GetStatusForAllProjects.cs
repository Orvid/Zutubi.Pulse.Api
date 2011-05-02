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
        /// <param name="includePersonal"></param>
        /// <param name="lastTimestamp"></param>
        /// <returns></returns>
        public static ProjectsStatus GetStatusForAllProjects(bool includePersonal, string lastTimestamp)
        {
            CheckAuth(AuthType.Guest);
            return Client.GetStatusForAllProjects(authToken, includePersonal, lastTimestamp);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="includePersonal"></param>
        /// <returns></returns>
        public static ProjectsStatus GetStatusForAllProjects(bool includePersonal)
        {
            CheckAuth(AuthType.Guest);
            return Client.GetStatusForAllProjects(authToken, includePersonal, "");
        }
    }
}
