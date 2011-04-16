using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The FileChange type holds information about a change to a single file as part of a larger changelist.
    /// </summary>
    public struct FileChange
    {
        /// <summary>
        /// The path of the file that was changed.
        /// </summary>
        public String File;
        /// <summary>
        /// The revision of the file.
        /// </summary>
        public String Revision;
        /// <summary>
        /// The change to the file.
        /// </summary>
        public FileChangeAction Action;
    }
    /// <summary>
    /// This enum holds the possible values of a FileChange's Action property.
    /// </summary>
    public enum FileChangeAction
    {
        /// <summary>
        /// The file was added.
        /// </summary>
        Add,
        /// <summary>
        /// The file was branched.
        /// </summary>
        Branch,
        /// <summary>
        /// The file was deleted.
        /// </summary>
        Delete,
        /// <summary>
        /// The file was modified.
        /// </summary>
        Edit,
        /// <summary>
        /// The file was integrated.
        /// </summary>
        Integrate,
        /// <summary>
        /// The file was merged.
        /// </summary>
        Merge,
        /// <summary>
        /// The file was moved.
        /// </summary>
        Move,
        /// <summary>
        /// The change is unknown.
        /// </summary>
        Unknown
    }
}
