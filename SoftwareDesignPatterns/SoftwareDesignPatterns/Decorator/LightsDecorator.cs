using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Decorator
{
    public class LightsDecorator: TreeDecorator
    {

        public override string Display()
        {
            return base.Display() + "; Lights turned on!";
        }
    }
}
