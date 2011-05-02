using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// Tests if a given path can be pulled up in the template hierarchy to the given ancestor. To be pulled up a path must:
        /// <para>1. Refer to an existing item of composite type</para>
        /// <para>2. Be in a templated scope</para>
        /// <para>3. Not be marked permanent</para>
        /// <para>4. Not be defined in any ancestor</para>
        /// <para>5. Not be defined in any other descendent of the specified ancestor</para>
        /// <para>6. Not contain any references to items not visible from the specified ancestor</para>
        /// <para>The given ancestor must be a strict ancestor of the templated collection item that owns the specified path.</para>
        /// Note that this method does not take security into account: i.e. it does not check that the user has permission to write into the ancestor.
        /// </summary>
        /// <param name="path">The path to test.</param>
        /// <param name="ancestorKey">Key of the templated collection item to pull the path up to (must be an ancestor of the path's template owner).</param>
        /// <returns>True if the path may be pulled up to the given ancestor.</returns>
        public static bool CanPullUpConfig(string path, string ancestorKey)
        {
            CheckAuth(AuthType.Guest);
            return Client.CanPullUpConfig(authToken, path, ancestorKey);
        }
    }
}
