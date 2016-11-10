namespace SoftwareDesignPatterns.Decorator
{
    public class GreenChristmasTree : IChristmasTree
    {
        string IChristmasTree.Display()
        {
            return "Green X'Mas Tree";
        }

    }
}
