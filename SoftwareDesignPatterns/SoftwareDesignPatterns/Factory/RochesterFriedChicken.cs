using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Factory
{
    class RochesterFriedChicken : IFood
    {
        public void GetFood()
        {
            Console.WriteLine("RochesterFriedChicken - Cooking Started!");
            Boil();
            AddSecretIngredients();
            Fry();
            Console.WriteLine("RochesterFriedChicken - Cooking Completed!");
        }

        private void AddSecretIngredients()
        {
            Console.WriteLine("---RochesterFriedChicken - Adding secret ingredients");
        }

        private void Boil()
        {
            Console.WriteLine("---RochesterFriedChicken - Boiling chicken");
        }

        private void Fry()
        {
            Console.WriteLine("---RochesterFriedChicken - Frying chicken");
        }
    }
}
