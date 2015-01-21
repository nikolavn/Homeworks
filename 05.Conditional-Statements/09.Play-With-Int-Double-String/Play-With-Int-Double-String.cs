using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double ");
        Console.WriteLine("3 --> string");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter an integer");
                int integerInput = int.Parse(Console.ReadLine());
                Console.WriteLine(integerInput + 1);
                break;
            case 2:
                Console.WriteLine("Enter an integer");
                double doubleInput = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleInput + 1);
                break;
            case 3:
                Console.WriteLine("Enter an integer");
                string stringInput = Console.ReadLine();
                Console.WriteLine(stringInput + "*");
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}

