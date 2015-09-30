using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Taxi:ITransporter
    {
        private double PricePerKilometer { get; set; }
        private double Distance { get; set; }

        public Taxi(double pricePerKilometer,double distance)
        {
            this.PricePerKilometer = pricePerKilometer;
            this.Distance = distance;
        }

        public double CalculateFare()
        {
            double fare = this.PricePerKilometer * this.Distance;

            return fare;
        }
    }
}
