using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I
{
    public class HPLaserJetPrinter : IPrinterTask, IFaxTask, IPrintDuplexTask
    {
        public void Fax(string content)
        {
            Console.WriteLine("Faxing...");
        }

        public void Print(string PrintContent)
        {
            Console.WriteLine("Printing...");
        }

        public void PrintDuplex(string content)
        {
            Console.WriteLine("Print duplexing...");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scaning...");
        }
    }
}
