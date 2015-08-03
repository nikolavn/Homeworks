using System;

namespace PerformanceTests
{
    class RunTests
    {
        static void Main()
        {
            Console.WriteLine(new String('-', 20) + "Arithmetic Operations Tests" + new String('-', 20) + Environment.NewLine);
            ArithmeticOperations.AdditionTests();
            Console.WriteLine();
            ArithmeticOperations.SubstractionTests();
            Console.WriteLine();
            ArithmeticOperations.IncrementationTests();
            Console.WriteLine();
            ArithmeticOperations.MultiplicationTests();
            Console.WriteLine();
            ArithmeticOperations.DivisionTests();
            Console.WriteLine(Environment.NewLine + new String('-', 20) + "Mathematical Operations Tests" + new String('-', 20) + Environment.NewLine);
            MathematicalOperations.FloatTests();
            Console.WriteLine();
            MathematicalOperations.DoubleTests();
            Console.WriteLine();
            MathematicalOperations.DecimalTests();

        }
    }
}
