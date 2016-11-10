namespace SoftwareDesignPatterns.Decorator
{
    public class TopperDecorator:TreeDecorator
    {

        public override string Display()
        {
            return base.Display() + "; Topper placed on top of tree!";
        }
    }
}
