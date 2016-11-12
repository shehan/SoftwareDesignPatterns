using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Builder
{
    // this is the builder interface
    public interface IBurgerBuilder
    {
        void AddCondimentsToBuns();

        void AddPattiesToBun();

        Burger GetBurger();
    }
}
