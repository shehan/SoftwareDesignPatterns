namespace SoftwareDesignPatterns.Decorator
{
    public class GiftDecorator:TreeDecorator
    {
        public override string Display()
        {
            return base.Display() + "; Gifts placed under the tree!";
        }
    }
}
