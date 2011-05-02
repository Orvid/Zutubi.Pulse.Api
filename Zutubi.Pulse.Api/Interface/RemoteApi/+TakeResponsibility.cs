using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// <para>Takes responsibility for the given project. The user 
        /// represented by token will be responsible for the build until the 
        /// responsibility is cleared. An optional comment can be provided to
        /// communicate with other users why responsibility has been taken and/or
        /// what actions are being taken.</para>
        /// 
        /// <para>Only one user may be responsible at a time. If another user
        /// is responsible, it is up to them to clear responsibility before 
        /// another user can take it. Only users with administration privileges 
        /// can override this.</para>
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="comment">
        /// Optional comment to communicate to other users (shown along
        /// with the message indicating the responsible user).
        /// </param>
        /// <returns>True.</returns>
        public static bool TakeResponsibility(string projectName, string comment)
        {
            CheckAuth(AuthType.Guest);
            return Client.TakeResponsibility(authToken, projectName, comment);
        }
    }
}
