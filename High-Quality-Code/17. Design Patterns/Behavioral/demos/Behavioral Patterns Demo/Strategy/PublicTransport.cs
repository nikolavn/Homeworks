using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class PublicTransport:ITransporter
    {
        private double TicketPrice { get; set; }

        public PublicTransport(double ticketPrice)
        {
            this.TicketPrice = ticketPrice;
        }

        public double CalculateFare()
        {
            double fare = this.TicketPrice;

            return fare;
        }
    }
}
