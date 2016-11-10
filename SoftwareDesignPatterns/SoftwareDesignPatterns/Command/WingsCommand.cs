namespace SoftwareDesignPatterns.Command
{
    //this is a concrete command class
    public class WingsCommand : ICommand
    {
        Wings _wings;        
        bool _isCompleted;

        public WingsCommand(Wings wings)
        {
            _wings = wings;
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
            //   Console.WriteLine(string.Format("Pouring beer: {0). Quantity: {1}"), _brand,_quantity);
            _wings.Cook();
            _isCompleted = true;
        }

    }
}
