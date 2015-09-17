using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Demo
{
    class Roller : IMeasuresInterpreter
    {
        private readonly MeasuresProvider testMeasures = new MeasuresProvider();

        public bool IsAboveMinimum(int min)
        {
            bool aboveMinimum = true;

            if (testMeasures.GenerateOutput() < min)
            {
                aboveMinimum = false;
            }

            return aboveMinimum;
        }

        public bool IsBelowMaximum(int max)
        {
            bool belowMaximum = true;

            if (testMeasures.GenerateOutput() > max)
            {
                belowMaximum = false;
            }

            return belowMaximum;
        }
    }
}
