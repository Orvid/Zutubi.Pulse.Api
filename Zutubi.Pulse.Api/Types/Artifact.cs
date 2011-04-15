using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The Artifact type holds information about an artifact captured during a build.
    /// </summary>
    public struct Artifact
    {
        /// <summary>
        /// Name of the build stage that the artifact was captured from. 
        /// </summary>
        public String Stage;
        /// <summary>
        /// Name of the command that the artifact was captured from. 
        /// </summary>
        public String Command;
        /// <summary>
        /// The artifact name. 
        /// </summary>
        public String Name;
        /// <summary>
        /// Path that when appended to the base pulse™ URL
        /// forms a link to the artifact (of the form described
        /// on the Pulse URL Scheme page. To use this link, prepend
        /// the base URL for pulse™ and append the path of the file
        /// within the artifact that you want to access. If the artifact
        /// is an HTML report, appending is not necessary (pulse™ will take
        /// you to the index file for the report).
        /// </summary>
        public String PermaLink;
    }
}
