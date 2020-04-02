using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
   public class AutomobileController
    {
        IAutomobile _automobile;

        public AutomobileController(IAutomobile automobile)
        {
            this._automobile = automobile;
        }

        public void Ignition()
        {
            _automobile.Ignition();
        }

        public void Stop()
        {
            _automobile.Stop();
        }
    }
}
