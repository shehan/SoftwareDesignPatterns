using System;

namespace SoftwareDesignPatterns.Command
{
    // this is a Receiver class
    public class Steak
    {
        SteakType _type;
        SteakPreperation _preperation;

        public Steak(SteakType type, SteakPreperation preperation)
        {
            _type = type;
            _preperation = preperation;
        }

        public void Cook()
        {
            Console.WriteLine(string.Format("Cooked a {0} {1} steak", _preperation, _type));
        }

        public enum SteakType
        {
            Tenderloin,
            Ribeye,
            TBone
        }

        public enum SteakPreperation
        {
            Medium,
            WellDone,
            Rare
        }
    }
}
