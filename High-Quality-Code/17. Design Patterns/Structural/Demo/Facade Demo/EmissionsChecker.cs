using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Demo
{
    public class EmissionsChecker
    {
        private const int Co2DangerLevel = 90;
        private const int So2DangerLevel = 110;
        private readonly IMeasuresInterpreter emissionsSensor = new Sensor();

        public EmissionsChecker()
        {

        }

        public void CO2Check()
        {
            Console.WriteLine("CO2 level : {0}", emissionsSensor.IsBelowMaximum(Co2DangerLevel) ? "OK" : "Not OK");
        }

        public void SO2Check()
        {
            Console.WriteLine("SO2 level : {0}", emissionsSensor.IsBelowMaximum(So2DangerLevel) ? "OK" : "Not OK");
        }
    }
}
