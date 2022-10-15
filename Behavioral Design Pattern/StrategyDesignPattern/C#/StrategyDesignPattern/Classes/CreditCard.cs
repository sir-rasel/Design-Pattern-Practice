using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Classes
{
    class CreditCard
    {
        private double amount = 1000;
        public string Number { get; set; }
        public string Date { get; set; }
        public string CVC { get; set; }

        public CreditCard(string number, string date, string cVC)
        {
            Number = number;
            Date = date;
            CVC = cVC;
        }

        public double GetAmount()
        {
            return amount;
        }

        public void SetAmount(double value)
        {
            amount = value;
        }
    }
}
