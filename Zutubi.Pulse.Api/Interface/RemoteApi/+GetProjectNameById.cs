using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// Gets the name of a project by its database id, if such a project exists.
        /// </summary>
        /// <param name="id">Id of the project's row in the database.</param>
        /// <returns>
        /// The name of the project with the given id, 
        /// or the empty if there is no such project.
        /// </returns>
        public static string GetProjectNameById(int id)
        {
            CheckAuth(AuthType.Guest);
            return Client.GetProjectNameById(authToken, id.ToString());
        }
    }
}
