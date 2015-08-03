using System;
using System.Linq;


namespace CorectUseOfVariables
{
    public class Statistics
    {
        public void PrintStatistics(double[] dataArray, int dataArrayElementsCount)
        {
            double maximumValue = 0;

            for (int i = 0; i < dataArrayElementsCount; i++)
            {
                if (dataArray[i] > maximumValue)
                {
                    maximumValue = dataArray[i];
                }
            }

            this.PrintValue(maximumValue);
            
            double minimumValue = 0;

            for (int i = 0; i < dataArrayElementsCount; i++)
            {
                if (dataArray[i] < minimumValue)
                {
                    minimumValue = dataArray[i];
                }
            }

            this.PrintValue(minimumValue);

            double dataArrayElementsSum = 0;

            for (int i = 0; i < dataArrayElementsCount; i++)
            {
                dataArrayElementsSum += dataArray[i];
            }

            double elementsAverageValue = dataArrayElementsSum / dataArrayElementsCount;
            
            this.PrintValue(elementsAverageValue);
        }

        public void PrintValue(double value)
        {
            Console.WriteLine(value);
        }
    }
}