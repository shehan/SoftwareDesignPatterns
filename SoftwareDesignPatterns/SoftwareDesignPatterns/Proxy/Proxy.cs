using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Proxy
{
    public class Proxy : IReal
    {
        Real _real;
        public void ProcessRequest(string message)
        {
            _real = new Real();
            Console.WriteLine(string.Format("This is the proxy object sending message '{0}' to the real object",message));
            _real.ProcessRequest(message);            
        }
    }
}
