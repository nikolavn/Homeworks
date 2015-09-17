using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Demo
{
    public class MeasuresProvider
    {
        private readonly Random generator = new Random();

        public MeasuresProvider()
        {

        }

        public int GenerateOutput()
        {
            return generator.Next(15, 115);
        }
    }
}
