using System;

namespace SoftwareDesignPatterns.Command
{
    // this is a Receiver class
    public class Pizza
    {
        string[] _toppings;

        public Pizza(string[] toppings)
        {
            _toppings = toppings;
        }

        public void Cook()
        {
            Console.WriteLine(string.Format("Cooked a pizza with toppings: {0}",string.Join(",",_toppings)));
        }

    }
}
