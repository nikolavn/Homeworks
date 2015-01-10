using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int firstVariable = 5;
        int secondVariable = 10;

        Console.WriteLine("Before exchange a= {0} and b= {1}.",firstVariable,secondVariable);

        firstVariable = firstVariable * secondVariable;
        secondVariable = firstVariable / secondVariable;
        firstVariable = firstVariable / secondVariable;

        Console.WriteLine("After exchange a= {0} and b= {1}.", firstVariable, secondVariable);
    }
}

