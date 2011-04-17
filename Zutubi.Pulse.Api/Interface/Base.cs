using System;
using System.Collections.Generic;
using System.Text;
using org.apache.xmlrpc.client;

namespace Zutubi.Pulse.Api
{
    /// <summary>
    /// The main interface to the Pulse Server.
    /// </summary>
    public static partial class Interface
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
                    if (prjnames.Length > 0)
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
    }
}
