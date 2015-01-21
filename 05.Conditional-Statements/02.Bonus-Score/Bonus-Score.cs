using System;

class BonusScore
{
    static void Main()
    {            
        Console.WriteLine("Enter score [1..9]: ");
        int score = int.Parse(Console.ReadLine());

        if (score>=1&&score<=3)
        {
            Console.WriteLine("Score with bonus: {0}",(score*10));
        }
        else if (score>=4&&score<=6)
        {
            Console.WriteLine("Score with bonus: {0}",(score*100));
        }
        else if (score>=7&&score<=9)
        {
            Console.WriteLine("Score with bonus: {0}",(score*1000));
        }
        else
        {
            Console.WriteLine("invalid score");
        }       
    }
}

