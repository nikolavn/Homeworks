using System;
using System.Threading;
using System.Globalization;
  
class PointInCircleOutsideRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.WriteLine("Enter X coordinate: ");
        double xCoord = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Y coordinate: ");
        double yCoord = double.Parse(Console.ReadLine());

        double circleRadius = 1.5;
        bool isInCircle = false;
        bool isOutRectangle = false;

        if (((1-xCoord)*(1-xCoord)+(1-yCoord)*(1-yCoord))<(circleRadius*circleRadius))
        {
            isInCircle = true;
        }

        if (xCoord<-1||xCoord>5&&yCoord<-1||yCoord>1)
        {
            isOutRectangle = true;
        }

        if (isInCircle&&isOutRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

