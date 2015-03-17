using System;

class DefiningClassesPart1
{
    static void Main()
    {
        GSMTest gsmTest = new GSMTest();
        gsmTest.RunTests();

        GSMCallHistoryTest callsTest = new GSMCallHistoryTest();
        callsTest.RunTests();
    }
}
