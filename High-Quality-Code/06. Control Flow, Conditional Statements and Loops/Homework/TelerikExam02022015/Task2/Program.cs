using System;

class Program
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int result= 0;
        int number = 0;

        input = input.ToLower();

        for (int counter = 0; counter < input.Length; counter++)
        {
            if (input[counter]=='@')
            {
                Console.WriteLine(result);
            }
            else
            {
                bool isNumber = int.TryParse(input[counter].ToString(),out number);

                if (isNumber)
                {
                    result *= int.Parse(input[counter].ToString());
                }
                else if(Char.IsLetter(input[counter]))
                {
                    result+= (input[counter]-97);
                }
                else
                {
                    result %= inputNumber;
                }
            }
        }
    }
}

