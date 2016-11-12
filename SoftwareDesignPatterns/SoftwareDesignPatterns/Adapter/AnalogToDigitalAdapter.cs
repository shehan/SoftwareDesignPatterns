using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Adapter
{
    // Object Adapter Example
    public class AnalogToDigitalAdapter : IAdapter
    {
        Digital _digital;

        public void ConvertToDigital(Analog data)
        {           
            Console.WriteLine("--Converting Analog to Digital--");
            int convertedValue = (int) Math.Round(data.AnalogValue);
            _digital = new Digital(convertedValue);
        }
    }
}
