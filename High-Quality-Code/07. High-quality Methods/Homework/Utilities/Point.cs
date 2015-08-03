using System;

namespace Utilities
{
    public struct Point
    {
        private double x;
        private double y;

        public Point(double xCoord, double yCoord)
            : this()
        {
            this.X = xCoord;
            this.Y = yCoord;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
    }
}
