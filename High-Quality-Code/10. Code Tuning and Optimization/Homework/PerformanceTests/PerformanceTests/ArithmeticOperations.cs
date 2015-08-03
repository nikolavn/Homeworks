using System;
using System.Diagnostics;

namespace PerformanceTests
{
    class ArithmeticOperations
    {
        public static void AdditionTests()
        {
            Stopwatch stopWatchAddtion = new Stopwatch();

            int intAdditionOutcome = 0;

            stopWatchAddtion.Restart();
            for (int i = 0; i < 100000; i++)
            {
                intAdditionOutcome += 100;
            }
            stopWatchAddtion.Stop();

            Console.WriteLine("Time elapsed for int addition: {0}", stopWatchAddtion.Elapsed);

            long longAdditionOutcome = 0L;

            stopWatchAddtion.Restart();
            for (int i = 0; i < 100000; i++)
            {
                longAdditionOutcome += 100;
            }
            stopWatchAddtion.Stop();

            Console.WriteLine("Time elapsed for long addition: {0}", stopWatchAddtion.Elapsed);

            float floatAdditionResult = 0f;

            stopWatchAddtion.Restart();
            for (int i = 0; i < 100000; i++)
            {
                floatAdditionResult += 100;
            }
            stopWatchAddtion.Stop();

            Console.WriteLine("Time elapsed for float addition: {0}", stopWatchAddtion.Elapsed);

            double doubleAdditionResult = 0.0;

            stopWatchAddtion.Restart();
            for (int i = 0; i < 100000; i++)
            {
                doubleAdditionResult += 100;
            }
            stopWatchAddtion.Stop();

            Console.WriteLine("Time elapsed for double addition: {0}", stopWatchAddtion.Elapsed);

            decimal decimalAdditionResult = 0m;

            stopWatchAddtion.Restart();
            for (int i = 0; i < 100000; i++)
            {
                decimalAdditionResult += 100;
            }
            stopWatchAddtion.Stop();

            Console.WriteLine("Time elapsed for decimal addition: {0}", stopWatchAddtion.Elapsed);

        }

        public static void SubstractionTests()
        {
            Stopwatch substractonStopwatch = new Stopwatch();

            int intSubstractionResult = 0;

            substractonStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                intSubstractionResult -= 100;
            }
            substractonStopwatch.Stop();

            Console.WriteLine("Time elapsed for int substraction: {0}", substractonStopwatch.Elapsed);

            long longSubstractionResult = 0L;

            substractonStopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                longSubstractionResult -= 100;
            }
            substractonStopwatch.Stop();

            Console.WriteLine("Time elapsed for long substraction: {0}", substractonStopwatch.Elapsed);

            float floatSubstractionResult = 0f;

            substractonStopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                floatSubstractionResult -= 100;
            }
            substractonStopwatch.Stop();

            Console.WriteLine("Time elapsed for float substraction: {0}", substractonStopwatch.Elapsed);

            double doubleSubstractionResult = 0.0;

            substractonStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                doubleSubstractionResult -= 100;
            }
            substractonStopwatch.Stop();

            Console.WriteLine("Time elapsed for double substraction: {0}", substractonStopwatch.Elapsed);

            decimal decimalSubstractionResult = 0m;

            substractonStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                decimalSubstractionResult -= 100;
            }
            substractonStopwatch.Stop();

            Console.WriteLine("Time elapsed for decimal substraction: {0}", substractonStopwatch.Elapsed);
        }

        public static void IncrementationTests()
        {
            Stopwatch incrementStopwatch = new Stopwatch();

            int intStartValue = 0;

            incrementStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                intStartValue++;
            }
            incrementStopwatch.Stop();

            Console.WriteLine("Time elapsed for int increment: {0}", incrementStopwatch.Elapsed);

            long longStartValue = 0L;

            incrementStopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                longStartValue++;
            }
            incrementStopwatch.Stop();

            Console.WriteLine("Time elapsed for long increment: {0}", incrementStopwatch.Elapsed);

            float floatStartValue = 0f;

            incrementStopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                floatStartValue++;
            }
            incrementStopwatch.Restart();

            Console.WriteLine("Time elapsed for float increment: {0}", incrementStopwatch.Elapsed);

            double doubleStartValue = 0.0;

            incrementStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                doubleStartValue++;
            }
            incrementStopwatch.Restart();

            Console.WriteLine("Time elapsed for double increment: {0}", incrementStopwatch.Elapsed);

            decimal decimalStartValue = 0m;

            incrementStopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                decimalStartValue++;
            }
            incrementStopwatch.Stop();

            Console.WriteLine("Time elapsed for decimal increment: {0}", incrementStopwatch.Elapsed);

        }

        public static void MultiplicationTests()
        {
            Stopwatch multiplicationStopwatch = new Stopwatch();

            int intMultiplicationResult = 1;

            multiplicationStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                intMultiplicationResult *= 1;
            }
            multiplicationStopwatch.Stop();

            Console.WriteLine("Time elapsed for int multiplication: {0}", multiplicationStopwatch.Elapsed);

            long longMultiplicationResult = 1L;

            multiplicationStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                longMultiplicationResult *= 1;
            }
            multiplicationStopwatch.Stop();

            Console.WriteLine("Time elapsed for long multiplication: {0}", multiplicationStopwatch.Elapsed);

            float floatMultiplicationResult = 1f;

            multiplicationStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                floatMultiplicationResult *= 1;
            }
            multiplicationStopwatch.Stop();

            Console.WriteLine("Time elapsed for float multiplication: {0}", multiplicationStopwatch.Elapsed);

            double doubleMultiplicationResult = 1.0;

            multiplicationStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                doubleMultiplicationResult *= 1;
            }
            multiplicationStopwatch.Stop();

            Console.WriteLine("Time elapsed for double multiplication: {0}", multiplicationStopwatch.Elapsed);

            decimal decimalMultiplicationResult = 1m;

            multiplicationStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                decimalMultiplicationResult *= 1;
            }
            multiplicationStopwatch.Stop();

            Console.WriteLine("Time elapsed for decimal multiplication: {0}", multiplicationStopwatch.Elapsed);
        }

        public static void DivisionTests()
        {
            Stopwatch divisionStopwatch = new Stopwatch();

            int intDivisionResult = 1;

            divisionStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                intDivisionResult /= 100;
            }
            divisionStopwatch.Stop();

            Console.WriteLine("Time elapsed for int division: {0}", divisionStopwatch.Elapsed);

            long longDivisionResult = 1L;

            divisionStopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                longDivisionResult /= 100;
            }
            divisionStopwatch.Stop();

            Console.WriteLine("Time elapsed for int division: {0}", divisionStopwatch.Elapsed);

            float floatDivisionResult = 1f;

            divisionStopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                floatDivisionResult /= 100;
            }
            divisionStopwatch.Stop();

            Console.WriteLine("Time elapsed for float division: {0}", divisionStopwatch.Elapsed);

            double doubleDivisionResult = 1.0;

            divisionStopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                doubleDivisionResult /= 100;
            }
            divisionStopwatch.Stop();

            Console.WriteLine("Time elapsed for double division: {0}", divisionStopwatch.Elapsed);

            decimal decimalDivisionResult = 1m;

            divisionStopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                decimalDivisionResult /= 100;
            }
            divisionStopwatch.Stop();

            Console.WriteLine("Time elapsed for decimal division: {0}", divisionStopwatch.Elapsed);
        }
    }
}
