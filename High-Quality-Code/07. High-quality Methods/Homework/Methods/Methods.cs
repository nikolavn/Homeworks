using System;
using Utilities;

namespace Methods
{
    class Methods
    {  
        static void Main()
        {
            Console.WriteLine(Utilities.GeometryOperations.CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(Utilities.ConsoleOutputOperations.DigitAsWord(5));
            
            Console.WriteLine(Utilities.ArrayOperations.FindMaxValuedElement(5, -1, 3, 2, 14, 2, 3));

            Utilities.ConsoleOutputOperations.PrintWithDigitsAfterDecimal(1.3, 2);
            Utilities.ConsoleOutputOperations.PrintAsPercent(0.7523, 2);
            Utilities.ConsoleOutputOperations.PrintRightAligned(2.30, 10);

            Point firstPoint = new Point(3, -1);
            Point secondPoint = new Point(3, 2.5);

            Console.WriteLine(Utilities.GeometryOperations.CalculateDistanceBetweenPoints(firstPoint,secondPoint));
            Console.WriteLine("Horizontal? " + Utilities.GeometryOperations.isLineHorizontal(firstPoint,secondPoint));
            Console.WriteLine("Vertical? " + Utilities.GeometryOperations.isLineVertical(firstPoint,secondPoint));

            Student peter = new Student("Peter", "Ivanov", "17.03.1992", "From Sofia");

            Student stella = new Student("Stella","Markova","03.11.1993","From Vidin, gamer, high results"); 

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
            
        }
    }
}
