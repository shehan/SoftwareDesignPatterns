using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Factory
{
    public class FoodFactory : IFoodFactory
    {
        public IFood OrderFood(string type)
        {
            IFood food = new FriedChicken();
              
            switch (type){
                case "RochesterFriedChicken": food = new RochesterFriedChicken(); break;
                case "SpicyFriedChicken": food = new SpicyFriedChicken(); break;
                case "GrilledChicken": food = new GrilledChicken(); break;
            }

            return food;
        }
    }
}
