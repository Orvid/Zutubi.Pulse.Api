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
        /// <param name="projects"></param>
        /// <param name="includePersonal"></param>
        /// <param name="lastTimestamp"></param>
        /// <returns></returns>
        public static ProjectsStatus GetStatusForProjects(string[] projects, bool includePersonal, string lastTimestamp)
        {
            CheckAuth(AuthType.Guest);
            return Client.GetStatusForProjects(authToken, projects, includePersonal, lastTimestamp);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="includePersonal"></param>
        /// <returns></returns>
        public static ProjectsStatus GetStatusForProjects(string[] projects, bool includePersonal)
        {
            CheckAuth(AuthType.Guest);
            return Client.GetStatusForProjects(authToken, projects, includePersonal, "");
        }
    }
}
