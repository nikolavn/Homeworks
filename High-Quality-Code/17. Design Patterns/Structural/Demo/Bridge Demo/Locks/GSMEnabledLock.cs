using System;

namespace Bridge_Demo
{
    class GSMEnabledLock : ILockable
    {
        public void Lock()
        {
            Console.WriteLine("GSM enabled lock - locked");
        }

        public void UnLock()
        {
            Console.WriteLine("GSM enabled lock - unlocked");
        }

        public void SendSMSOnDoorBreak()
        {
            Console.WriteLine("Door has been breached");
        }
    }
}
