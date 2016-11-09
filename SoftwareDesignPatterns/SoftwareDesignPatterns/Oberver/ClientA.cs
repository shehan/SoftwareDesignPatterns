using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
