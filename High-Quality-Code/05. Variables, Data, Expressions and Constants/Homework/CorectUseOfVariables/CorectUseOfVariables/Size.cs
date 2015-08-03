using System;
using System.Linq;

namespace CorectUseOfVariables
{
    public class Size
    {
        private double width, height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        
        public static Size GetRotatedSize(Size figure, double rotationAngle)
        {
            double rotatedFigureWidth = Math.Abs(Math.Cos(rotationAngle)) * figure.width + Math.Abs(Math.Sin(rotationAngle)) * figure.height;
            double rotatedFigureHeight = Math.Abs(Math.Sin(rotationAngle)) * figure.width + Math.Abs(Math.Cos(rotationAngle)) * figure.height;
            
            return new Size(rotatedFigureWidth, rotatedFigureHeight);
        }
    }
}
