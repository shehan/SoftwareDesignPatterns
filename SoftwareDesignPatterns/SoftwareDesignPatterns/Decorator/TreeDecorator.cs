namespace SoftwareDesignPatterns.Decorator
{
    public class TreeDecorator : IChristmasTree
    {
        IChristmasTree XmasTree;


        public void AddTreeDecoration(IChristmasTree tree)
        {
            XmasTree = tree;            
        }


        public virtual string Display()
        {
            return XmasTree.Display();
        }
    }
}
