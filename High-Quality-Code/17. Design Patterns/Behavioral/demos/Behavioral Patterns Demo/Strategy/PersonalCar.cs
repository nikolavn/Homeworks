using System;

namespace Strategy
{
    class PersonalCar:ITransporter
    {
        private double GasConsumption { get; set; }
        private double GasPrice { get; set; }
        private double Distance { get; set; }

        public PersonalCar(double gasConsumption,double gasPrice,double distance)
        {
            this.GasConsumption = gasConsumption;
            this.GasPrice = gasPrice;
            this.Distance = distance;
        }

        public double CalculateFare()
        {
            double fare = (this.Distance / 100) * this.GasConsumption * this.GasPrice;

            return fare;
        }
    }
}
