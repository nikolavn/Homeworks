using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Demo
{
    class VehicleInspection
    {
        private readonly EmissionsChecker emissions = new EmissionsChecker();
        private readonly BrakesChecker brakes = new BrakesChecker();

        public VehicleInspection()
        {

        }

        public void PerformCheck()
        {
            emissions.CO2Check();
            emissions.SO2Check();

            brakes.FrontBrakesCheck();
            brakes.RearBrakesCheck();
            brakes.HandBrakeCheck();
        }
    }
}
