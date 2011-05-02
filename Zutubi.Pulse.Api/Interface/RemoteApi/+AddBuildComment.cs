using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// Adds a comment to a build result. Comments are used to communicate with other users viewing the build.
        /// </summary>
        /// <param name="projectName">The name of the project owning the build.</param>
        /// <param name="buildId">The ID of the build to comment on.</param>
        /// <param name="message">The comment message to add.</param>
        /// <returns>The ID of the created comment.</returns>
        public static String AddBuildComment(string projectName, int buildId, string message)
        {
            CheckAuth(AuthType.Guest);
            return Client.AddBuildComment(authToken, projectName, buildId, message);
        }
    }
}
