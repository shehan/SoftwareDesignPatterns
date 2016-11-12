using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Adapter
{
    public class Analog
    {
        decimal _analogValue;
        public decimal AnalogValue
        {
            get
            {
                return _analogValue;
            }            
        }

        public Analog(decimal value)
        {
            _analogValue = value;
            Console.WriteLine("This is the Analog class");
            Console.WriteLine("Analog value: " + _analogValue);            
        }
    }
}
