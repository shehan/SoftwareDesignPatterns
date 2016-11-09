using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Decorator
{
    public class WhiteChristmasTree : IChristmasTree
    {
        string IChristmasTree.Display()
        {
            return "White X'Mas Tree";
        }

    }
}
