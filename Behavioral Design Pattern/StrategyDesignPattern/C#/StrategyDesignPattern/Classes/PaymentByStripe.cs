using StrategyDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Classes
{
    class PaymentByStripe : IPaymentStrategy
    {
        public string SecretKey { get; set; }
        public string Password { get; set; }

        public void CollectPaymentDetails()
        {
            SecretKey = "Stripe Key";
            Password = "Stripe Password";
            Console.WriteLine("Collecting Stripe Account Details...");
        }

        public void Pay(double amount)
        {
            Console.WriteLine("Paying " + amount + " using Stripe");
        }

        public bool ValidatePaymentDetails()
        {
            Console.WriteLine("Validating Stripe Info: ");
            return true;
        }
    }
}
