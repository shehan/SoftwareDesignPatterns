namespace SoftwareDesignPatterns.Decorator
{
    public class LightsDecorator: TreeDecorator
    {

        public override string Display()
        {
            return base.Display() + "; Lights turned on!";
        }
    }
}
