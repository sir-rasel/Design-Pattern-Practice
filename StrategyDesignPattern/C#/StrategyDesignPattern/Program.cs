using StrategyDesignPattern.Classes;
using StrategyDesignPattern.Interfaces;
using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentService paymentService = new PaymentService();

            paymentService.SetPaymentStrategy(new PaymentByCreditCard());
            paymentService.ProcessOrder(100);

            paymentService.SetPaymentStrategy(new PaymentByPaypal());
            paymentService.ProcessOrder(100);

            paymentService.SetPaymentStrategy(new PaymentByStripe());
            paymentService.ProcessOrder(100);
        }
    }
}
