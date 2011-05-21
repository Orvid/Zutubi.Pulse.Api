using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zutubi.Pulse.Api.Types;

namespace Zutubi.Pulse.Api.Example
{
    internal class Project
    {
        public string Name { get; private set; }
        public List<BuildResult> Builds { get; set; }
        public Health ProjectHealth { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public Project(string name)
        {
            this.Name = name;
        }

    }
}
