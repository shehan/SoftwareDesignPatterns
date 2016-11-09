using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Decorator
{
    public class GiftDecorator:TreeDecorator
    {
        public override string Display()
        {
            return base.Display() + "; Gifts placed under the tree!";
        }
    }
}
