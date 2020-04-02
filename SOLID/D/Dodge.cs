using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    class Dodge : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("Dodge Started");
        }

        public void Stop()
        {
            Console.WriteLine("Dodge Stopped");
        }
    }
}
