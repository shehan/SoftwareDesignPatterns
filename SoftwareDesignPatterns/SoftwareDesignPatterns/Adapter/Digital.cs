using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Adapter
{
    public class Digital
    {
        int _digitalValue;
        decimal DigitalValue
        {
            get
            {
                return _digitalValue;
            }
        }

        public Digital(int value)
        {
            _digitalValue = value;
            Console.WriteLine("This is the Digital class");
            Console.WriteLine("Digital value: " + value);
        }
    }
}
