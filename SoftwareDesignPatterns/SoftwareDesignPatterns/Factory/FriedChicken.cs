using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Factory
{
    public class FriedChicken : IFood
    {
        public void GetFood()
        {
            Console.WriteLine("FriedChicken - Coooking Started!");
            AddSpciesAndHerbs();
            FryChicken();
            Console.WriteLine("FriedChicken - Coooking Completed!");
        }

        private void FryChicken()
        {
            Console.WriteLine("---FriedChicken - Frying chicken");
        }

        private void AddSpciesAndHerbs()
        {
            Console.WriteLine("---FriedChicken - Adding spices and herbs");
        }
    }
}
