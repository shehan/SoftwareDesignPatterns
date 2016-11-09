using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
