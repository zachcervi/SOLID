using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I
{
  public  interface PrinterInterfaceBefore
    {
        public void Print(string PrintContent);
        public void Scan(string ScanContent);
        public void Fax(string FaxContent);
        public void PrintDuplex(string PrintDuplexContent);
    }
}
