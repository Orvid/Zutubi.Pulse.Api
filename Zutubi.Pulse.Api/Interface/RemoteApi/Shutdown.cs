using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// Request that this server shut down. This method will return 
        /// after the request is made, which is likely to be before the shutdown is complete.
        /// </summary>
        /// <param name="force">
        /// If true, running builds will be terminated to force
        /// a faster shutdown, if false running builds will be 
        /// allowed to complete.
        /// </param>
        /// <param name="exitJvm">
        /// If true, the JVM will be explicitly exited 
        /// (rather than being allowed to exit when there
        /// are no more non-daemon threads).
        /// </param>
        /// <returns>True.</returns>
        public static bool Shutdown(bool force, bool exitJvm)
        {
            CheckAuth(AuthType.Admin);
            return Client.Shutdown(authToken, force, exitJvm);
        }
    }
}
