using System;
using System.Diagnostics;

namespace PerformanceTests
{
    class MathematicalOperations
    {
        public static void FloatTests()
        {
            Stopwatch floatTestsStopwatch = new Stopwatch();

            floatTestsStopwatch.Start();
            for (int i = 0; i < 250; i++)
            {
                Math.Sqrt(244.123949f / i);
            }
            floatTestsStopwatch.Stop();

            Console.WriteLine("Time elapsed for float sqrt: {0}", floatTestsStopwatch.Elapsed);

            floatTestsStopwatch.Restart();
            for (int i = 0; i < 250; i++)
            {
                Math.Log10(1027.218374f / i);
            }
            floatTestsStopwatch.Stop();

            Console.WriteLine("Time elapsed for float log10: {0}", floatTestsStopwatch.Elapsed);

            floatTestsStopwatch.Restart();
            for (int i = 0; i < 250; i++)
            {
                Math.Sin(5965.826428f / i);
            }
            floatTestsStopwatch.Stop();

            Console.WriteLine("Time elapsed for float sin: {0}", floatTestsStopwatch.Elapsed);
        }

        public static void DoubleTests()
        {
            Stopwatch doubleTestsStopwatch = new Stopwatch();

            doubleTestsStopwatch.Start();
            for (int i = 0; i < 250; i++)
            {
                Math.Sqrt(244.123949 / i);
            }
            doubleTestsStopwatch.Stop();

            Console.WriteLine("Time elapsed for double sqrt: {0}", doubleTestsStopwatch.Elapsed);

            doubleTestsStopwatch.Restart();
            for (int i = 0; i < 250; i++)
            {
                Math.Log10(1027.218374 / i);
            }
            doubleTestsStopwatch.Stop();

            Console.WriteLine("Time elapsed for double log10: {0}", doubleTestsStopwatch.Elapsed);

            doubleTestsStopwatch.Restart();
            for (int i = 0; i < 250; i++)
            {
                Math.Sin(5965.826428 / i);
            }
            doubleTestsStopwatch.Stop();

            Console.WriteLine("Time elapsed for double sin: {0}", doubleTestsStopwatch.Elapsed);
        }

        public static void DecimalTests()
        {
            Stopwatch decimalTestsStopwatch = new Stopwatch();

            decimalTestsStopwatch.Start();
            for (int i = 0; i < 250; i++)
            {
                Math.Sqrt((double)244.123949m / i);
            }
            decimalTestsStopwatch.Stop();

            Console.WriteLine("Time elapsed for decimal sqrt: {0}", decimalTestsStopwatch.Elapsed);

            decimalTestsStopwatch.Restart();
            for (int i = 0; i < 250; i++)
            {
                Math.Log10((double)1027.218374m / i);
            }
            decimalTestsStopwatch.Stop();

            Console.WriteLine("Time elapsed for decimal log10: {0}", decimalTestsStopwatch.Elapsed);

            decimalTestsStopwatch.Restart();
            for (int i = 0; i < 250; i++)
            {
                Math.Sin((double)5965.826428m / i);
            }
            decimalTestsStopwatch.Stop();

            Console.WriteLine("Time elapsed for decimal sin: {0}", decimalTestsStopwatch.Elapsed);
        }
    }
}
