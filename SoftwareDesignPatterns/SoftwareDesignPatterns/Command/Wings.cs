using System;

namespace SoftwareDesignPatterns.Command
{
    public class Wings
    {
        // this is a Receiver class

        WingFlavor _flavor;
        int _quantity;

        public Wings(WingFlavor flavor, int quantity)
        {
            _flavor = flavor;
            _quantity = quantity;
        }

        public void Cook()
        {
            Console.WriteLine(string.Format("Cooked {0} {1} wings", _quantity, _flavor));
        }

        public enum WingFlavor
        {
            BBQ,
            HotGarlic,
            SweetChili,
            Teriyaki
        }
    }
}
