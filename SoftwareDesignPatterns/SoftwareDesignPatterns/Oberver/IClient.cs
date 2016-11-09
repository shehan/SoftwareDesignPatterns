using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Oberver
{
    public interface IClient
    {
        void notify(string message);
        
    }
}
