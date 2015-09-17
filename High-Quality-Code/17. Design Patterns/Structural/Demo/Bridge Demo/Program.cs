using Bridge_Demo.Doors;
using System;

namespace Bridge_Demo
{
    class Program
    {
        static void Main()
        {
            var locker = new Padlock(); // new GSMEnabledLock();

            var frontDoor = new EnforcedMetalDoor(locker);
            var backDoor = new WoodenDoor(locker);

            frontDoor.Lock();
            frontDoor.UnLock();
            Console.WriteLine(frontDoor.ToString());
            Console.WriteLine(new string('=',25));
            backDoor.Lock();
            Console.WriteLine(backDoor.ToString());
        }
    }
}
