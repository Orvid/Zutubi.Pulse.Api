using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zutubi.Pulse.Api.Example
{
    internal class ProjectList : List<Project>
    {
        public Project GetProject(string projectName)
        {
            foreach (Project p in this)
            {
                if (p.Name == projectName)
                {
                    return p;
                }
            }
            
            return null;
        }
    }
}
