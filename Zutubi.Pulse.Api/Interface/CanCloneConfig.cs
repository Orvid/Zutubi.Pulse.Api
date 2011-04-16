using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// Tests whether the given configuration path can be cloned.
        /// Only map elements (generally all named configuration objects)
        /// that are not the root of a template hierarchy may be cloned.
        /// This method does not verify whether the user actually has 
        /// permission to perform the clone: only that the path is cloneable.
        /// </summary>
        /// <param name="configPath">Path to test.</param>
        /// <returns>True if the given path exists and is cloneable.</returns>
        public static bool CanCloneConfig(string configPath)
        {
            CheckAuth();
            return (bool)Client.execute("RemoteApi.canCloneConfig", new object[] { authToken, configPath });
        }
    }
}
