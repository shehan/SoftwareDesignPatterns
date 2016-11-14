namespace SoftwareDesignPatterns.Command
{
    //this is a concrete command class
    public class PizzaCommand : ICommand
    {
        bool _isCompleted;
        Pizza _pizza;

        public PizzaCommand(Pizza pizza)
        {
            _pizza = pizza;
            _isCompleted = false;
        }

        public bool IsCompleted
        {
            get
            {
                return _isCompleted;
            }
        }

        public void Execute()
        {            
            _pizza.Cook();
            _isCompleted = true;
        }
    }
}
