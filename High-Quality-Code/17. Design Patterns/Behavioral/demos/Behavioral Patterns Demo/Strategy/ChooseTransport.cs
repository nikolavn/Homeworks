using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class ChooseTransport
    {
        private readonly ITransporter transport;

        public ChooseTransport(ITransporter transport)
        {
            this.transport = transport;
        }

        public void CostForRide()
        {
            Console.WriteLine("Cost for ride with {0} : {1}",this.transport.GetType().Name,this.transport.CalculateFare());
        }
    }
}
