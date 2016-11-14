using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Factory
{
    public class SpicyFriedChicken : IFood
    {
        public void GetFood()
        {
            Console.WriteLine("SpicyFriedChicken - Cooking Started");
            MixSpices();
            DeepFryChicken();
            Console.WriteLine("SpicyFriedChicken - Cooking Completed");
        }

        private void MixSpices()
        {
            Console.WriteLine("---SpicyFriedChicken - Mixing spices");
        }

        private void DeepFryChicken()
        {
            Console.WriteLine("---SpicyFriedChicken - Deepfry chicken");
        }
    }
}
