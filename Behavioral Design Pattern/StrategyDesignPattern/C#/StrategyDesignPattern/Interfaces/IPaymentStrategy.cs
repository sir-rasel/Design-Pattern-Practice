using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Interfaces
{
    public interface IPaymentStrategy
    {
        void CollectPaymentDetails();

        bool ValidatePaymentDetails();

        void Pay(double amount);
    }
}
