using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.S
{
    public class GarageStationUtility : IGarageUtility
    {
        public void OpenGate()
        {
            Console.WriteLine("Opening Garage....");
        }

        public void CloseGate()
        {
            Console.WriteLine("Closing Garage....");
        }
    }
}
