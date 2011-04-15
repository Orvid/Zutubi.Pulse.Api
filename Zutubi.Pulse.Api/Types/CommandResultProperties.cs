using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The CommandResultProperties type holds a set of key value pairs that provide extra details related to the execution of the command. 
    /// </summary>
    public struct CommandResultProperties
    {
        /// <summary>
        /// The actual properties vary from command to command. 
        /// </summary>
        public List<NameValuePair> Properties;
    }
}
