using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Decorator
{
    public class GreenChristmasTree : IChristmasTree
    {
        string IChristmasTree.Display()
        {
            return "Green X'Mas Tree";
        }

    }
}
