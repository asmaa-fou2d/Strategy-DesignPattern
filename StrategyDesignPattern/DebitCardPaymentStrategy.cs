using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class DebitCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            // business implementation
            Console.WriteLine("Customer pays Rs " + amount + " using Debit Card");
        }
    }
}
