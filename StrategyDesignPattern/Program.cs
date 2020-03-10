using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Payment Type : CreditCard or DebitCard or Cash");
            string PaymentType = Console.ReadLine();
            Console.WriteLine("Payment type is : " + PaymentType);
            Console.WriteLine("\nPlease enter Amount to Pay : ");
            double Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Amount is : " + Amount);

            PaymentContext payment = new PaymentContext();

            if ("CreditCard".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
            {
                payment.SetPaymentStrategy(new CreditCardPaymentStrategy());
            }
            else if ("DebitCard".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
            {
                payment.SetPaymentStrategy(new DebitCardPaymentStrategy());
            }
            else if ("Cash".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
            {
                payment.SetPaymentStrategy(new CashPaymentStrategy());
            }
            payment.Pay(Amount);
            Console.ReadKey();
        }
    }
}
