namespace SoftwareDesignPatterns.Decorator
{
    public class WhiteChristmasTree : IChristmasTree
    {
        string IChristmasTree.Display()
        {
            return "White X'Mas Tree";
        }

    }
}
