using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The CommandResultProperties type holds a set of key value pairs that provide extra details related to the execution of the command. 
    /// </summary>
    public class CommandResultProperties : List<NameValuePair>
    {
        /// <summary>
        /// Get's a property by it's name.
        /// </summary>
        /// <param name="name">The name of the property to search for.</param>
        /// <returns>The NameValuePair that matches.</returns>
        public NameValuePair GetByName(string name)
        {
            foreach (NameValuePair nvp in this)
            {
                if (nvp.Name == name)
                {
                    return nvp;
                }
            }
            throw new Exception("Could not find the specified item");
        }

        /// <summary>
        /// Check if the specified property is set.
        /// </summary>
        /// <param name="name">The property to check for.</param>
        /// <returns>True if the property is set.</returns>
        public bool IsPropertySet(string name)
        {
            foreach (NameValuePair nvp in this)
            {
                if (nvp.Name == name)
                {
                    if (nvp.Value != "")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
