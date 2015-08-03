using System;

namespace Abstraction
{
    class Circle : Figure
    {

        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value <= 0) 
                {
                    throw new ArgumentException("Radius can not be negative or 0");
                }

                this.radius = value;
            }
        }

        public override double Area
        {
            get { return Math.PI * this.Radius * this.Radius; }
        }

        public override double Perimeter
        {
            get { return 2 * Math.PI * this.Radius; }
        }
    }
}
