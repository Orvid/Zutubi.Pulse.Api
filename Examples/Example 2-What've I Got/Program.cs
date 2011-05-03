using Zutubi.Pulse.Api;
using System.Collections.Generic;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverUrl = "pulse";
            string user = "user";
            string pass = "secret";

            Interface.SetServer(serverUrl);
            Interface.Login(user, pass);
            List<string> prjNames = Interface.GetAllProjectNames();
            foreach (string s in prjNames)
            {
                System.Console.WriteLine("There is a project named \"" + s + "\".");
            }
            Interface.Logout();
        }
    }
}
