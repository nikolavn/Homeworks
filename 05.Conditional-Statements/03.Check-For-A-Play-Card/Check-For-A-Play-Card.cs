using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter card: ");
        string card = Console.ReadLine();
        
		string[] validCards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        bool isValidCard = false;

        for (int i = 0; i < validCards.Length; i++)
        {
            if (String.Equals(card,validCards[i],StringComparison.Ordinal))
            {
                isValidCard = true;               
            }            
        }

        if (isValidCard)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

