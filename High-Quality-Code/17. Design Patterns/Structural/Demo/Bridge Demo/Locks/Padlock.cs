using System;

namespace Bridge_Demo
{
    public class Padlock : ILockable
    {
        public void Lock()
        {
            Console.WriteLine("Padlock - locked"); ;
        }

        public void UnLock()
        {
            Console.WriteLine("Padlock - unlocked");
        }
    }
}
