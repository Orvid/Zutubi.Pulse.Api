using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using CookComputing.XmlRpc;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// This struct describes a plugin.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Plugin
    {
        /// <summary>
        /// The plugin's id.
        /// </summary>
        [XmlRpcMember("id")]
        string ID;
        /// <summary>
        /// The plugin version.
        /// </summary>
        [XmlRpcMember("version")]
        string Version;
        /// <summary>
        /// The scope of the plugin.
        /// </summary>
        [XmlRpcMember("scope")]
        string Scope;
    }
}
