using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class GarageStation
    {
        IGarageUtility _garageUtil;

        public GarageStation(IGarageUtility garageUtil)
        {
            this._garageUtil = garageUtil;
        }
        public void OpenForService()
        {
            _garageUtil.OpenGate();
        }
        public void DoService()
        {
            Console.WriteLine("Servicing Jeep Wrangler....");
        }
        public void CloseGarage()
        {
            _garageUtil.CloseGate();
        }
    }
}
