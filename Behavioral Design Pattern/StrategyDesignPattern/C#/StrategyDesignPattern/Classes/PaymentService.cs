using StrategyDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Classes
{
    public class PaymentService
    {

        private double Cost;
        private bool IncludeDelivery = true;

        public IPaymentStrategy PaymentStrategy { get; set; }

        public void ProcessOrder(double cost)
        {
            Cost = cost;
            PaymentStrategy.CollectPaymentDetails();
            if (PaymentStrategy.ValidatePaymentDetails())
            {
                PaymentStrategy.Pay(getTotal());
            }
        }

        private double getTotal()
        {
            return IncludeDelivery ? Cost + 10 : Cost;
        }

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            PaymentStrategy = strategy;
        }
    }
}
