using System;
using System.Collections.Generic;
using System.Linq;

class GSMTest
{
    public void RunTests()
    {
        GSM myGSM = new GSM("Note 2", "Samsung", 100, "Me");
        GSM yourGSM = new GSM("M9", "HTC", 1000, "Someone", new Battery("HTC Battery", 109, 400, BatteryType.LiIon));
        GSM herGSM = new GSM("Lumia", "Microsoft", 500, "Jane Doe", new Battery("Microsoft Battery", 87, 234, BatteryType.NiMH), new Display(10));
        GSM hisGSM = new GSM("One", "OnePlus", 300, "John Doe", new Battery("Some Battery", 123, 265, BatteryType.LiPoly), new Display(13, 16000000));

        GSM[] phones = { myGSM, yourGSM, herGSM, hisGSM };

        foreach (var phone in phones)
        {
            Console.WriteLine(phone.ToString());
            Console.WriteLine(new string('-', 35));
        }

        Console.WriteLine(GSM.IPhone4S.ToString());
    }
}

