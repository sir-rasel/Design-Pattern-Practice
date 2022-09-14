using StrategyDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Classes
{
    class PaymentByPaypal : IPaymentStrategy
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public void CollectPaymentDetails()
        {
            Email = "PayPal Mail";
            Password = "PayPal Password";
            Console.WriteLine("Collecting PayPal Account Details...");
        }

        public void Pay(double amount)
        {
            Console.WriteLine("Paying " + amount + " using PayPal");
        }

        public bool ValidatePaymentDetails()
        {
            Console.WriteLine("Validating Paypal Info: ");
            return true;
        }
    }
}
