using System.Collections.Generic;

namespace SoftwareDesignPatterns.Command
{
    // This is the Invoker class
    public class Waiter
    {
        private IList<ICommand> _commandList;

        public void AddOrder(ICommand order)
        {
            if (_commandList == null)
                _commandList = new List<ICommand>();

            _commandList.Add(order);
        }

        public void ExecuteOrder()
        {
            foreach (ICommand order in _commandList)
                if(!order.IsCompleted)
                    order.Execute();
        }
    }
}
