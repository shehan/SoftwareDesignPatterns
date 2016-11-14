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
            _wings.Cook();
            _isCompleted = true;
        }

    }
}
