using System;
using System.Collections.Generic;
using Zutubi.Pulse.Api;
using Zutubi.Pulse.Api.Types;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverUrl = "pulse";
            string user = "user";
            string pass = "secret";
            string project = "my project";
            bool completedOnly = true;
            int maxResultsToReturn = 5;

            // Connect to the server and login.
            Interface.SetServer(serverUrl);
            Interface.Login(user, pass);

            // Get the most recent builds from the specified project
            List<BuildResult> results = Interface.GetLatestBuildsForProject(project, completedOnly, maxResultsToReturn);
            // Enumerate through the results, and show some of the important information.
            foreach (BuildResult br in results)
            {
                Console.WriteLine("Build number: " + br.ID + ":");
                Console.WriteLine("  Status: " + br.Status);
                Console.WriteLine("  Stages:");
                foreach (StageResult sr in br.Stages)
                {
                    Console.WriteLine("    Stage " + sr.Name + ":");
                    Console.WriteLine("      Status: " + sr.Status);
                    Console.WriteLine("      Agent : " + sr.Agent);
                }
            }

            // And finally we logout of the session.
            Interface.Logout();
        }
    }
}