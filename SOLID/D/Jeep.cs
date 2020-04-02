using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class Jeep : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("Jeep Started");
        }

        public void Stop()
        {
            Console.WriteLine("Jeep Stopped");
        }
    }
}
