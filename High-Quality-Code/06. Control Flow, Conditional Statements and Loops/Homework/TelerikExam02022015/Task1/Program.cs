using System;


class Program
{
    static void Main()
    {
        
        int numberOfStudents = int.Parse(Console.ReadLine());        
        int sheetsPerStudent = int.Parse(Console.ReadLine());        
        float pricePerRealm = float.Parse(Console.ReadLine());

        double realms = (double)((numberOfStudents * sheetsPerStudent) / 500d);
        double result = realms * pricePerRealm;
        
        Console.WriteLine("{0:F2}",result);
		
    }
}

