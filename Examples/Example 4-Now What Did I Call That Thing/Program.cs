using System;
using Zutubi.Pulse.Api;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverUrl = "pulse";
            string user = "user";
            string pass = "secret";
            int projectId = 4132;

            // Connect to the server and login.
            Interface.SetServer(serverUrl);
            Interface.Login(user, pass);

            string prjName = Interface.GetProjectNameById(projectId);
            System.Console.WriteLine("The name of the project is " + prjName + ".");

            // And finally we logout of the session.
            Interface.Logout();
        }
    }
}
