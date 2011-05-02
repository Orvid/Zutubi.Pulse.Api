using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;
using System.Runtime.InteropServices;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The CommandResultProperty type provides extra details related to the execution of the command. 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CommandResultProperties
    {
        /// <summary>
        /// The name.
        /// </summary>
        [XmlRpcMember("name")]
        public string[] Name;
        /// <summary>
        /// The value.
        /// </summary>
        [XmlRpcMember("property")]
        public string[] Property;
    }
}
