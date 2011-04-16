using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// Request that the given active build is cancelled. 
        /// This function returns at the time the request is made, which 
        /// is likely to be before the build is cancelled (if indeed it is cancelled).
        /// </summary>
        /// <param name="projectName">The name of the project that is building.</param>
        /// <param name="buildID">The id of the build to cancel.</param>
        /// <returns>True if cancellation was requested, false if the build was not found or was not in progress.</returns>
        public static bool CancelBuild(string projectName, int buildID)
        {
            CheckAuth();
            return (bool)Client.execute("RemoteApi.cancelBuild", java.util.Arrays.asList(new object[] { authToken, projectName, buildID }));
        }
    }
}
