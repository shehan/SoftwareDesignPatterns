using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Factory
{
    public class GrilledChicken : IFood
    {
        public void GetFood()
        {
            Console.WriteLine("GrilledChicken - Cooking Started!");
            GrillChicken();
            Console.WriteLine("GrilledChicken - Cooking Completed!");
        }

        private void GrillChicken()
        {
            Console.WriteLine("---GrilledChicken - Grilling chicken");
        }
    }
}
