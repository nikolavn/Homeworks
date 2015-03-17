using System;
using System.Collections.Generic;
using System.Linq;

class GSMCallHistoryTest
{
    public void RunTests()
    {
        GSM myGSM = new GSM("Note 2", "Samsung", 100, "Me");

        myGSM.AddCall(new Call(new DateTime(2015, 3, 13), new DateTime(2015, 3, 13, 21, 03, 45), "0888123456", 3623));
        myGSM.AddCall(new Call(new DateTime(2015, 3, 14), new DateTime(2015, 3, 14, 3, 56, 23), "0888123456", 263));
        myGSM.AddCall(new Call(new DateTime(2015, 3, 15), new DateTime(2015, 3, 15, 14, 27, 13), "0888123456", 23));
        myGSM.AddCall(new Call(new DateTime(2015, 3, 16), new DateTime(2015, 3, 16, 19, 55, 23), "0888123456", 13472));

        foreach (var call in myGSM.CallHistory)
        {
            Console.WriteLine(call.ToString());
        }

        Console.WriteLine("\nTotal price of calls: {0:C2}", myGSM.CalculateCallsPrice(0.37));

        myGSM.DeleteCall(myGSM.CallHistory.OrderByDescending(c => c.Duration).First());

        Console.WriteLine("\nTotal price of calls: {0:C2}", myGSM.CalculateCallsPrice(0.37));

        myGSM.ClearHistory();

        foreach (var call in myGSM.CallHistory)
        {
            Console.WriteLine(call.ToString());
        }

    }
}

