using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O
{
    public class SalarySavingsAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 5) / 100;
            return Interest;
        }
    }
}
