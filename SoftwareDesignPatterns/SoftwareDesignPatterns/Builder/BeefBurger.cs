using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Builder
{
    // this is a concrete builder class
    public class BeefBurger : IBurgerBuilder
    {
        private Burger _beefBurger;

        public BeefBurger()
        {
            _beefBurger = new Burger();
        }

        public void AddCondimentsToBuns()
        {
            Console.WriteLine("Beef Burger - Add Condiments");
            _beefBurger._condiments = "Tomato, Onions, Cheese";
        }

        public void AddPattiesToBun()
        {
            Console.WriteLine("Beef Burger - Add Patties");
            _beefBurger._meatType = "Beef";
        }

        public Burger GetBurger()
        {
            return _beefBurger;
        }
    }
}
