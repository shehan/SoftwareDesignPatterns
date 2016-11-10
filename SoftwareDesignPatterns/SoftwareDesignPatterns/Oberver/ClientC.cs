using System;

namespace SoftwareDesignPatterns.Oberver
{
    public class ClientC : IClient
    {
        public void notify(string message)
        {
            Console.WriteLine("Client C has been notified! Message: " + message);
        }
    }
}
