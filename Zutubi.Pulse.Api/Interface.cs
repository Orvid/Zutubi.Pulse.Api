using System;
using System.Collections.Generic;
using System.Text;
using org.apache.xmlrpc.client;
using Zutubi.Pulse.Api.Types;
using java.util;

namespace Zutubi.Pulse.Api.Example
{
    /// <summary>
    /// The main interface to the Pulse Server.
    /// </summary>
    public static class Interface
    {
        /// <summary>
        /// This is the config that the Client uses.
        /// </summary>
        public static XmlRpcClientConfigImpl ClientConfig = new XmlRpcClientConfigImpl();
        /// <summary>
        /// This is the Client that does all of the work.
        /// </summary>
        public static XmlRpcClient Client = new XmlRpcClient();
        /// <summary>
        /// True if you are currently logged in to a server.
        /// </summary>
        public static bool Authenticated = false;
        /// <summary>
        /// True if you are currently connected to a server.
        /// </summary>
        public static bool ConnectedToServer = false;
        /// <summary>
        /// This is used internally. It stores the Authentication Token used for login.
        /// </summary>
        private static String authToken;
        /// <summary>
        /// A string containing the location of the server that your currently connected to.
        /// </summary>
        public static String Server;
        /// <summary>
        /// The current username being used to connect.
        /// </summary>
        public static String Username;

        /// <summary>
        /// This is purely a convience method to ensure the user is connected properly.
        /// </summary>
        private static void CheckAuth()
        {
            if (!Authenticated)
            {
                throw new Exception("Attempted to perform an action while un-authenticated, which requires authentication.");
            }
        }

        /// <summary>
        /// Initiate the connection to the specified server.
        /// </summary>
        /// <param name="server"></param>
        public static void SetServer(string server)
        {
            if (!ConnectedToServer)
            {
                ClientConfig.setServerURL(new java.net.URL(server));
                Client.setConfig(ClientConfig);
                if (((string)Client.execute("RemoteApi.ping", java.util.Collections.EMPTY_LIST)) == "pong")
                {
                    ConnectedToServer = true;
                    Server = server;
                }
                else
                {
                    throw new Exception("An Error Occured While Connecting to the Server! Please check your connection and try again.");
                }
            }
            else
            {
                throw new Exception("Your already connected to a server! You must disconect from that server before you can connect to a new one!");
            }
        }

        /// <summary>
        /// Login to the current server.
        /// </summary>
        /// <param name="usrname">The username to use to login.</param>
        /// <param name="pass">The password to use to login.</param>
        public static void Login(string usrname, string pass)
        {
            if (ConnectedToServer)
            {
                if (!Authenticated)
                {
                    string tmptoken = (string)Client.execute("RemoteApi.login", java.util.Arrays.asList(new object[] { usrname, pass }));
                    object[] prjnames = (object[])Client.execute("RemoteApi.getAllProjectNames", java.util.Arrays.asList(tmptoken));
                    if (((string[])prjnames).Length > 0)
                    {
                        authToken = tmptoken;
                        Authenticated = true;
                        Username = usrname;
                    }
                    else
                    {
                        throw new Exception("Login failed. Incorrect Username/Password.");
                    }
                }
                else
                {
                    throw new Exception("You must logout before you can login under different credentials!");
                }
            }
            else
            {
                throw new Exception("You have to connect to a server before you can login!");
            }
        }

        /// <summary>
        /// Logout of the current session. 
        /// </summary>
        public static void Logout()
        {
            if (Authenticated)
            {
                Client.execute("RemoteApi.logout", java.util.Arrays.asList(authToken));
                Username = "";
                authToken = "";
                Authenticated = false;
            }
            else
            {
            }
        }

        /// <summary>
        /// Disconnect from the current server.
        /// </summary>
        public static void Disconnect()
        {
            if (Authenticated)
            {
                Logout();
            }
            if (ConnectedToServer)
            {
                Client = new XmlRpcClient();
                ClientConfig = new XmlRpcClientConfigImpl();
                Server = "";
                ConnectedToServer = false;
            }
        }

        /// <summary>
        /// Get the names of all of the projects visible to the currently authenticated user.
        /// </summary>
        /// <returns>A list of the project names.</returns>
        public static List<String> GetAllProjectNames()
        {
            CheckAuth();
            List<String> prjnms = new List<String>();
            object[] nms = (object[])Client.execute("RemoteApi.getAllProjectNames", java.util.Arrays.asList(authToken));
            foreach (object o in nms)
            {
                prjnms.Add((string)o);
            }
            return prjnms;
        }

        /// <summary>
        /// The method used to serialize a StageResult from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized StageResult</returns>
        public static StageResult SerializeStageResult(HashMap hm)
        {
            StageResult sr = new StageResult();
            sr.Agent = (string)hm.get("agent");
            sr.Completed = (Boolean)hm.get("completed");
            //sr.EndTime = (DateTime)hm.get("endTime");
            sr.ErrorCount = (int)hm.get("errorCount");
            sr.Name = (string)hm.get("name");
            sr.Progress = (int)hm.get("progress");
            //sr.StartTime = (DateTime)hm.get("startTime");
            sr.Status = (string)hm.get("status");
            sr.Succeeded = (bool)hm.get("succeeded");
            sr.WarningCount = (int)hm.get("warningCount");
            HashMap hm2 = (HashMap)hm.get("commands");
            sr.Commands = SerializeCommandResult(hm2);
            HashMap hm3 = (HashMap)hm.get("tests");
            sr.Tests = SerializeTestSummary(hm3);
            return sr;
        }

        /// <summary>
        /// The method used to serialize a CommandResult from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized CommandResult</returns>
        public static CommandResult SerializeCommandResult(HashMap hm)
        {
            CommandResult cr = new CommandResult();
            cr.Completed = (bool)hm.get("completed");
            //cr.EndTime = (DateTime)hm.get("endTime");
            cr.ErrorCount = (int)hm.get("errorCount");
            cr.Name = (string)hm.get("name");
            cr.Progress = (int)hm.get("progress");
            //cr.StartTime = (DateTime)hm.get("startTime");
            cr.Status = (string)hm.get("status");
            cr.Succeeded = (bool)hm.get("succeeded");
            cr.WarningCount = (int)hm.get("warningCount");
            //cr.Properties = (CommandResultProperties)hm.get("properties");
            return cr;
        }

        /// <summary>
        /// The method used to serialize a TestSummary from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized TestSummary</returns>
        public static TestSummary SerializeTestSummary(HashMap hm)
        {
            TestSummary ts = new TestSummary();
            ts.Errors = (int)hm.get("errors");
            ts.ExpectedFailures = (int)hm.get("expectedFailures");
            ts.Failures = (int)hm.get("failures");
            ts.Passed = (int)hm.get("passed");
            ts.Skipped = (int)hm.get("skipped");
            ts.Total = (int)hm.get("total");
            return ts;
        }

        /// <summary>
        /// The method used to serialize a BuildResult from a HashMap.
        /// </summary>
        /// <param name="hm">The input HashMap</param>
        /// <returns>The Serialized BuildResult</returns>
        public static BuildResult SerializeBuildResult(HashMap hm)
        {
            BuildResult br = new BuildResult();
            br.Completed = (bool)hm.get("completed");
            //br.EndTime = (DateTime)hm.get("endTime");
            br.EndTimeMillis = (string)hm.get("endTimeMillis");
            br.ErrorCount = (int)hm.get("errorCount");
            br.ID = (string)hm.get("id");
            br.Progress = (int)hm.get("progress");
            br.Reason = (string)hm.get("reason");
            br.Revision = (string)hm.get("revision");
            //br.StartTime = (DateTime)hm.get("startTime");
            br.StartTimeMillis = (string)hm.get("startTimeMillis");
            br.Status = (string)hm.get("status");
            br.WarningCount = (int)hm.get("warningCount");
            foreach (HashMap hm2 in (HashMap[])hm.get("stages"))
            {
                br.Stages.Add(SerializeStageResult(hm2));
            }
            HashMap hm3 = (HashMap)hm.get("tests");
            br.Tests = SerializeTestSummary(hm3);
            return br;
        }

        /// <summary>
        /// Returns the most recent build results for the given project that meet the specified criteria. The returned results are ordered most recent first.
        /// </summary>
        /// <param name="projectName">Name of the project to retrieve the builds of; may be the name of a project template in which case all concrete descendants of that template will be queried.</param>
        /// <param name="completedOnly">If true, only completed builds will be returned, if false the result may contain in progress builds.</param>
        /// <param name="maxResults">The maximum number of results to return. </param>
        /// <returns>The latest build results for the given project which meet the given criteria, sorted most recent first.</returns>
        public static List<BuildResult> GetMostRecentBuildsForProject(string projectName, bool completedOnly, int maxResults)
        {
            CheckAuth();
            List<BuildResult> rslt = new List<BuildResult>();
            object[] builds = (object[])Client.execute("RemoteApi.getLatestBuildsForProject", java.util.Arrays.asList(new object[] { authToken, projectName, completedOnly, maxResults }));
            foreach (HashMap hm in (HashMap[])builds)
            {
                rslt.Add(SerializeBuildResult(hm));
            }
            return rslt;
        }

        /// <summary>
        /// Adds a comment to a build result. Comments are used to communicate with other users viewing the build.
        /// </summary>
        /// <param name="projectName">The name of the project owning the build.</param>
        /// <param name="buildId">The ID of the build to comment on.</param>
        /// <param name="message">The comment message to add.</param>
        /// <returns>The ID of the created comment.</returns>
        public static String AddBuildComment(string projectName, int buildId, string message)
        {
            return (string)Client.execute("RemoteApi.addBuildComment", java.util.Arrays.asList(new object[] { authToken, projectName, buildId, message }));
        }

        /// <summary>
        /// Request that the given active build is cancelled. 
        /// This function returns at the time the request is made, which 
        /// is likely to be before the build is cancelled (if indeed it is cancelled).
        /// </summary>
        /// <param name="projectName">The name of the project that is building.</param>
        /// <param name="buildID">The id of the build to cancel.</param>
        /// <returns>True if cancellation was requested, false if the build was not found or was not in progress.</returns>
        public static bool CancelBuild(string projectName, int buildID)
        {
            return (bool)Client.execute("RemoteApi.cancelBuild", java.util.Arrays.asList(new object[] { authToken, projectName, buildID }));
        }

        public static bool CancelQueuedBuildRequest(string id)
        {
            return (bool)Client.execute("RemoteApi.cancelQueuedBuildRequiest", new object[] { authToken, id });
        }



    }
}
