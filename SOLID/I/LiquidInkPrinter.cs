using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I
{
    public class LiquidInkPrinter : IPrinterTask
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Printing....");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scanning...");
        }
    }
}
