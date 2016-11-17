using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Template
{
    public abstract class ATM
    {
        public void  PerformTransaction()
        {
            GetCard();
            GetPIN();
            Transaction();
            ReturnCard();
        }

        private void GetPIN()
        {
            Console.WriteLine("Get PIN");
        }

        private void GetCard()
        {
            Console.WriteLine("Get Card");
        }

        private void ReturnCard()
        {
            Console.WriteLine("Return Card");
        }

        public abstract void Transaction();
    }
}
