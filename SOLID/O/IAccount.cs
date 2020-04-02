using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O
{
    interface IAccount
    {
        decimal Balance { get; set; }
        decimal CalcInterest();
    }
}
