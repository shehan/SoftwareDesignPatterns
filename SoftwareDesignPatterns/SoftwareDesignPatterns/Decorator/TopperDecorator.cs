using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Decorator
{
    public class TopperDecorator:TreeDecorator
    {

        public override string Display()
        {
            return base.Display() + "; Topper placed on top of tree!";
        }
    }
}
