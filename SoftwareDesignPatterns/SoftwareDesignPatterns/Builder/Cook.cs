using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Builder
{
    // This is the director class
    public class Cook
    {
        IBurgerBuilder _builder;

        public Cook(IBurgerBuilder builder)
        {
            _builder = builder;

            _builder.AddPattiesToBun();
            _builder.AddCondimentsToBuns();
        }

        public Burger GetMeal()
        {
            return _builder.GetBurger();
        }
    }
}
