using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// A name value pair.
    /// </summary>
    public struct NameValuePair
    {
        /// <summary>
        /// The name.
        /// </summary>
        public string Name;
        /// <summary>
        /// The value.
        /// </summary>
        public String Value;
        /// <summary>
        /// The default constructor.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public NameValuePair(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
