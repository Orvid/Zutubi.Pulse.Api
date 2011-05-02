using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// A trivial ping method that can be useful for testing connectivity.
        /// </summary>
        /// <returns>The string: "pong".</returns>
        public static string Ping()
        {
            return Client.Ping();
        }
    }
}
