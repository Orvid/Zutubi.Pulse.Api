using System;
using System.Collections.Generic;
using System.Text;
using Zutubi.Pulse.Api.Backend;
using CookComputing.XmlRpc;

namespace Zutubi.Pulse.Api
{
    /// <summary>
    /// The main interface to the Pulse Server.
    /// </summary>
    public static partial class Interface
    {
        /// <summary>
        /// This is the Client that does all of the work.
        /// </summary>
        private static BackendInterface Client;
        /// <summary>
        /// True if you are currently logged in to a server.
        /// </summary>
        public static bool Authenticated = false;
        /// <summary>
        /// The level of authentication the current user has.
        /// </summary>
        public static AuthType AuthLevel = AuthType.Guest;
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
        /// The possible levels of authentication.
        /// </summary>
        public enum AuthType : int
        {
            /// <summary>
            /// The top authorization level, this level has access to everything.
            /// </summary>
            Admin = 20,
            /// <summary>
            /// This level of authorization has access to everything
            /// except managing the server itself.
            /// </summary>
            PrjAdmin = 19,
            /// <summary>
            /// Has the ability to administer a project,
            /// and can modify, and add new things to the project.
            /// Can also trigger builds.
            /// </summary>
            AdminDev = 18,
            /// <summary>
            /// Has same abilities as <seealso cref="AdminDev"/>,
            /// minus the ability to add new things to the project.
            /// </summary>
            HighDev = 15,
            /// <summary>
            /// Has the ability to trigger builds.
            /// </summary>
            Developer = 10,
            /// <summary>
            /// Can only read things.
            /// </summary>
            ReadOnly = 5,
            /// <summary>
            /// The lowest possible level. Can do nothing (except for login).
            /// </summary>
            Guest = 0
        }

        /// <summary>
        /// This is purely a convience method to ensure the user is connected properly.
        /// It also checks if the user has an AuthLevel above the required level.
        /// </summary>
        private static void CheckAuth(AuthType required)
        {
            if (!Authenticated)
            {
                throw new Exception("Attempted to perform an action, while un-authenticated, which requires authentication.");
            }
            else
            {
                if (required > AuthLevel)
                {
                    throw new Exception("You don't have permission to perform this action.");
                }
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
                    string tmptoken = Client.Login(usrname, pass);
                    String[] prjnames = Client.GetAllProjectNames(tmptoken);
                    if (prjnames.Length > 0)
                    {
                        authToken = tmptoken;
                        Authenticated = true;
                        Username = usrname;
                        AuthLevel = AuthType.Admin;
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
        /// Initiate the connection to the specified server.
        /// </summary>
        /// <param name="server"></param>
        public static void SetServer(string server)
        {
            if (!ConnectedToServer)
            {
                Client = (BackendInterface)XmlRpcProxyGen.Create(typeof(BackendInterface));
                Client.KeepAlive = false;
                Client.Url = server;
                if (Client.Ping() == "pong")
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
        /// Logout of the current session. 
        /// </summary>
        public static void Logout()
        {
            if (Authenticated)
            {
                Client.Logout(authToken);
                Username = "";
                authToken = "";
                AuthLevel = AuthType.Guest;
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
                Client = (BackendInterface)XmlRpcProxyGen.Create(typeof(BackendInterface));
                Server = "";
                ConnectedToServer = false;
            }
        }
    }
}
