using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api.Types
{
    /// <summary>
    /// The Changelist type holds information about an SCM change that affected some build.
    /// </summary>
    public struct ChangeList
    {
        /// <summary>
        /// The revision of the changelist, e.g. a repository revision for Subversion.
        /// </summary>
        public String Revision;
        /// <summary>
        /// The user the submitted the changelist.
        /// </summary>
        public String Author;
        /// <summary>
        /// The date at which the change was submitted (according to the SCM server clock).
        /// </summary>
        public String Date;
        /// <summary>
        /// The comment provided by the author for the change.
        /// </summary>
        public String Comment;
        /// <summary>
        /// The files affected by the changelist.
        /// </summary>
        public List<FileChange> Files;
    }
}
