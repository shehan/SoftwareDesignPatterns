using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Builder
{
    // this is a concrete builder class
    public class ChickenBurger : IBurgerBuilder
    {
        private Burger _chickenBurger;

        public ChickenBurger()
        {
            _chickenBurger = new Burger();
        }

        public void AddCondimentsToBuns()
        {
            Console.WriteLine("Chicken Burger - Add Condiments");
            _chickenBurger._condiments = "Mayonnaise, Ketchup, Lettuces";
        }

        public void AddPattiesToBun()
        {
            Console.WriteLine("Chicken Burger - Add Patties");
            _chickenBurger._meatType = "Chicken";
        }

        public Burger GetBurger()
        {
            return _chickenBurger;
        }
    }
}
