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
            CheckAuth();
            List<String> prjnms = new List<String>();
            object[] nms = (object[])Client.execute("RemoteApi.getAllProjectNames", java.util.Arrays.asList(authToken));
            foreach (object o in nms)
            {
                prjnms.Add((string)o);
            }
            return prjnms;
        }
    }
}
