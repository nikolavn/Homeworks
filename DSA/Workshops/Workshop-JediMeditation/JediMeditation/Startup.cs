namespace JediMeditation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var jedisWaiting = int.Parse(Console.ReadLine());

            string[] jedisQueue = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var masters = jedisQueue.Where(x => x[0] == 'm').Select(x => x);
            var knights = jedisQueue.Where(x => x[0] == 'k').Select(x => x);
            var padawans = jedisQueue.Where(x => x[0] == 'p').Select(x => x);

            Console.WriteLine("{0} {1} {2}",string.Join(" ", masters),string.Join(" ", knights),string.Join(" ", padawans));
        }
    }
}
