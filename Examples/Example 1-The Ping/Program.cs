using Zutubi.Pulse.Api;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverUrl = "pulse";
            Interface.SetServer(serverUrl);
            string response = Interface.Ping();
            System.Console.WriteLine(response);
        }
    }
}
