using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O
{
    public class CorporateAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;

        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 3) / 100;
            return Interest;
        }
    }
}
