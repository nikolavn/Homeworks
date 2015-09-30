using System;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            ITransporter transport = new PersonalCar(5.7, 2.23, 3.45);
            //ITransporter transport = new Taxi(0.95, 3.45);
            //ITransporter transport = new PublicTransport(1.30);
            var chooseTransport = new ChooseTransport(transport);
            chooseTransport.CostForRide(); 
        }
    }
}
