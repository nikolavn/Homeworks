using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter weight on earth: ");
        double weightOnEarth = double.Parse(Console.ReadLine());

        Console.WriteLine("Weight on moon is: {0:F3}",(0.17*weightOnEarth));
    }
}

