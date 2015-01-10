using System;

class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        byte age;
        char gender;
        ulong personalIDNumber;
        uint employeeNumber;

        firstName = "Bai";
        lastName = "Ivan";
        age = 52;
        gender = 'm';
        personalIDNumber = 8306112507;
        employeeNumber = 27569999;

        Console.WriteLine("Name:{0} {1}",firstName,lastName);
        Console.WriteLine("Age: {0}",age);
        Console.WriteLine("Gender: {0}",gender);
        Console.WriteLine("Personal ID Number: {0}",personalIDNumber);
        Console.WriteLine("Employee Number: {0}",employeeNumber);
    }
}


