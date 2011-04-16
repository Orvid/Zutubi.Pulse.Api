using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// Cancels a queued build request, if it is found in the queue.
        /// Note that this method cannot be used to cancel an active build 
        /// (which has left the queue) - instead CancelBuild should be used.
        /// </summary>
        /// <param name="id">Identifier of the queued request - available in the structures returned by GetBuildQueueSnapshot</param>
        /// <returns>
        /// True if the build request was found and cancelled;
        /// false if it was not found (the build may have been activated).
        /// </returns>
        public static bool CancelQueuedBuildRequest(string id)
        {
            CheckAuth();
            return (bool)Client.execute("RemoteApi.cancelQueuedBuildRequiest", new object[] { authToken, id });
        }
    }
}
