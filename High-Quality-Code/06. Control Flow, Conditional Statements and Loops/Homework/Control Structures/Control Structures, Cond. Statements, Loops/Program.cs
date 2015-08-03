using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Structures__Cond.Statements__Loops
{
    class Program
    {
        static void Main()
        {
            int expectedValue = 10;
            int[] array = new int[10];

            for (int i = 0; i < 100; )
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                    }

                    i++;
                }
                else
                {
                    Console.WriteLine(array[i]);
                    i++;
                }
            }

            Potato potato = new Potato();
            Chef misho = new Chef();
            Vegetable[] potatoes = new Vegetable[3] { potato, potato, potato };

            if (potato != null)
            {
                if (potato.HasBeenPeeled() && !potato.IsRotten())
                {
                    misho.Cook(potatoes);
                }
            }

            const int MIN_X = int.MinValue;
            const int MIN_Y = int.MinValue;
            const int MAX_X = int.MinValue;
            const int MAX_Y = int.MinValue;
            int x = 0;
            int y = 0;
            bool inRangeX = (x >= MIN_X) && (x <= MAX_X);
            bool inRangeY = (y >= MIN_X) && (y <= MAX_X);
            bool isCellVisited = true;

            if (inRangeX && inRangeY && !isCellVisited)
            {
                VisitCell();
            }
        }

        public static void VisitCell()
            {
                throw new NotImplementedException("Method not implemented yet.");
            }
    }
}
