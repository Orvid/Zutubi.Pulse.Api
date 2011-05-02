using System;
using System.Collections.Generic;
using System.Text;
using Zutubi.Pulse.Api.Types;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// Returns the most recent build results for the given project that meet the specified criteria. The returned results are ordered most recent first.
        /// </summary>
        /// <param name="projectName">Name of the project to retrieve the builds of; may be the name of a project template in which case all concrete descendants of that template will be queried.</param>
        /// <param name="completedOnly">If true, only completed builds will be returned, if false the result may contain in progress builds.</param>
        /// <param name="maxResults">The maximum number of results to return. </param>
        /// <returns>The latest build results for the given project which meet the given criteria, sorted most recent first.</returns>
        public static List<BuildResult> GetLatestBuildsForProject(string projectName, bool completedOnly, int maxResults)
        {
            CheckAuth(AuthType.Guest);
            List<BuildResult> rslt = new List<BuildResult>();
            foreach (BuildResult br in Client.GetLatestBuildsForProject(authToken, projectName, completedOnly, maxResults))
            {
                rslt.Add(br);
            }
            return rslt;
        }
    }
}
