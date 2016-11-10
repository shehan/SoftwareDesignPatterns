using System;

namespace SoftwareDesignPatterns.Oberver
{
    public class ClientA : IClient
    {
        public void notify(string message)
        {
            Console.WriteLine("Client A has been notified! Message: "+ message);
        }
    }
}
