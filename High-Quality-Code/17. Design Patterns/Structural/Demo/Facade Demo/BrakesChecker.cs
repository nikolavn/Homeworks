using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Demo
{
    class BrakesChecker
    {
        private const int FrontBrakesMinGrip = 65;
        private const int RearBrakesMinGrip = 55;
        private const int HandBrakeMinGrip = 50;
        private readonly IMeasuresInterpreter brakesRoller = new Roller();

        public void FrontBrakesCheck()
        {
            Console.WriteLine("Front brakes : {0}",brakesRoller.IsAboveMinimum(FrontBrakesMinGrip)?"OK":"Not OK");
        }

        public void RearBrakesCheck()
        {
            Console.WriteLine("Rear brakes : {0}", brakesRoller.IsAboveMinimum(RearBrakesMinGrip) ? "OK" : "Not OK");
        }

        public void HandBrakeCheck()
        {
            Console.WriteLine("Hand brake : {0}", brakesRoller.IsAboveMinimum(HandBrakeMinGrip) ? "OK" : "Not OK");
        }

    }
}
