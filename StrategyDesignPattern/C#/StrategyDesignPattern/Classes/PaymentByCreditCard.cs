using StrategyDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Classes
{
    class PaymentByCreditCard : IPaymentStrategy
    {
        public CreditCard card;
        public void CollectPaymentDetails()
        {
            card = new CreditCard("cardNumber", "expiryDate", "cvc");
            Console.WriteLine("Collecting Card Details...");
        }

        public void Pay(double amount)
        {
            Console.WriteLine("Paying " + amount + " using Credit Card");
            card.SetAmount(card.GetAmount() - amount);
        }

        public bool ValidatePaymentDetails()
        {
            Console.WriteLine("Validating Card Info: " + card);
            return true;
        }
    }
}
