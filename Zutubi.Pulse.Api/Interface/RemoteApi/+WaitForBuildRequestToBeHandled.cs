using System;
using System.Collections.Generic;
using System.Text;
using Zutubi.Pulse.Api.Types;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// Waits for a given length of time for a build request to be handled.
        /// A handled request is one that has either made its way into the 
        /// queue, or will never do so (e.g. if it is rejected). If the timeout
        /// is reached before the request is handled, this method will return
        /// as normal but the returned status will be UNHANDLED.
        /// </summary>
        /// <param name="requestId">Id of the build request, as returned by RemoteApi.triggerBuild.</param>
        /// <param name="timoutMilis">Number of milliseconds to wait for the request to be handled.</param>
        /// <returns>The status of the request.</returns>
        public static BuildRequestStatus WaitForBuildRequestToBeHandled(string requestId, int timoutMilis)
        {
            CheckAuth(AuthType.Guest);
            return Client.WaitForBuildRequestToBeHandled(authToken, requestId, timoutMilis);
        }
    }
}
