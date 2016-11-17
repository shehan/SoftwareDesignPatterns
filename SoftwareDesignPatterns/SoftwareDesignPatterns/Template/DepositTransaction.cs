using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Template
{
    public class DepositTransaction : ATM
    {
        public override void Transaction()
        {
            Console.WriteLine("Deposit Transaction");
        }
       
    }
}
