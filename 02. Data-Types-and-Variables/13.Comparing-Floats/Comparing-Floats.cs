using System;

class ComparingFloats
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        double eps = 0.000001;

        if (Math.Abs(secondNumber - firstNumber) < eps)
        {
            Console.WriteLine("Both numbers are equal with precision {0:F6}",eps);
        }
        else
        {
            Console.WriteLine("Both numbers are not equal with precision {0:F6}", eps);
        }
    }
}

