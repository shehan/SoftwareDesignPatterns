using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Proxy
{
    public class Real : IReal
    {
        public void ProcessRequest(string message)
        {
            Console.WriteLine(string.Format("This is the real object. Message received: '{0}'",message));
        }
    }
}
