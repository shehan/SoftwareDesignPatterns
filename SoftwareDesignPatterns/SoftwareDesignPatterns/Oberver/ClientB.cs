using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
