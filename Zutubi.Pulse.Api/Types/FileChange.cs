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
        /// The change to the file, one of: { add, branch, delete, edit, integrate, merge, move, unknown }.
        /// </summary>
        public String Action;
    }
}
