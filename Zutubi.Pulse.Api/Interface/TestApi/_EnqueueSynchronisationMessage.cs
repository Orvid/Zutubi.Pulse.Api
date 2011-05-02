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
        /// <param name="agent"></param>
        /// <param name="synchronous"></param>
        /// <param name="description"></param>
        /// <param name="succeed"></param>
        /// <returns></returns>
        public static bool EnqueueSynchronisationMessage(string agent, bool synchronous, string description, bool succeed)
        {
            CheckAuth(AuthType.Admin);
            return Client.EnqueueSynchronisationMessage(authToken, agent, synchronous, description, succeed);
        }
    }
}
