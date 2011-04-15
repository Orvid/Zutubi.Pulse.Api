using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The Feature type holds a message that was detected 
    /// during a build or extracted from a build artifact with
    /// a post-processor. Features are used for error, warning
    /// and information messages. Each feature also includes the 
    /// context in which the feature was found. For example, a 
    /// feature found in an artifact would include details of the 
    /// stage, command, artifact and file in which it was located. 
    /// The fields that hold this context information will not be
    /// present when the context is not applicable.
    /// </summary>
    public struct Feature
    {
        /// <summary>
        /// The type of feature, one of "error", "warning" or "info". 
        /// </summary>
        public String Level;
        /// <summary>
        /// The feature message, which may be multi-line if captured from an artifact with context.
        /// </summary>
        public String Message;
        /// <summary>
        /// Name of the build stage that the feature was found in, not present if the feature refers to the entire build.
        /// </summary>
        public String Stage;
        /// <summary>
        /// Name of the command that the feature was found in, not present if the feature was not specific to a command. 
        /// </summary>
        public String Command;
        /// <summary>
        /// Name of the artifact that the feature was extracted from, not present if the feature was not found in an artifact. 
        /// </summary>
        public String Artifact;
        /// <summary>
        /// Path of the artifact file that the feature was extracted from, not present if the feature was not found in an artifact. 
        /// </summary>
        public String Path;
    }
}
