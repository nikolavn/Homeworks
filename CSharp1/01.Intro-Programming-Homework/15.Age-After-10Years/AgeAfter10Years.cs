using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Enter birthday in format (dd.mm.yyyy): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            int age = DateTime.Now.Year - birthday.Year;

            Console.WriteLine();
            Console.WriteLine("Now you are {0} years old. After 10 years you will be {1} years old",age,age+10);
        }
    }

