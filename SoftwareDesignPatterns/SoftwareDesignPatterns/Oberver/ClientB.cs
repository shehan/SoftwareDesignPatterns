using System;

namespace SoftwareDesignPatterns.Oberver
{
    public class ClientB : IClient
    {
        public void notify(string message)
        {
            Console.WriteLine("Client B has been notified! Message: " + message);
        }
    }
}
