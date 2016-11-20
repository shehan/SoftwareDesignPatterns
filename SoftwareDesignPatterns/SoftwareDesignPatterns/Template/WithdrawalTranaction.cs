using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Template
{
    public class WithdrawalTranaction : ATM
    {
        public override void Transaction()
        {
            Console.WriteLine("Withdrawal Transaction - Start");

            GetAmount();
            ProvideCash();

        }

        private void GetAmount()
        {
            Console.WriteLine("Withdrawal Transaction - Get Amount");
        }

        private void ProvideCash()
        {
            Console.WriteLine("Withdrawal Transaction - Provide Cash");
        }
    }
}
