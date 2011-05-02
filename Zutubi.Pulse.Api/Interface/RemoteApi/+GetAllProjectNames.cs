using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// Get the names of all of the projects visible to the currently authenticated user.
        /// </summary>
        /// <returns>A list of the project names.</returns>
        public static List<String> GetAllProjectNames()
        {
            CheckAuth(AuthType.Guest);
            List<String> prjnms = new List<String>();
            String[] nms = Client.GetAllProjectNames(authToken);
            foreach (String o in nms)
            {
                prjnms.Add(o);
            }
            return prjnms;
        }
    }
}
