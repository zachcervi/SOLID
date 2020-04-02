using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I
{
    public interface IPrinterTask
    {
        public void Print(string PrintContent);
        public void Scan(string ScanContent);
    }
}
