namespace SoftwareDesignPatterns.Command
{
    //this is a concrete command class
    public class SteakCommand : ICommand
    {
        Steak _steak;
        bool _iscompleted;

        public bool IsCompleted
        {
            get
            {
                return _iscompleted;
            }
        }

        public SteakCommand(Steak steak)
        {
            _steak = steak;
            _iscompleted = false;
        }

        public void Execute()
        {
            _steak.Cook();
            _iscompleted = true;
        }

    }
}
