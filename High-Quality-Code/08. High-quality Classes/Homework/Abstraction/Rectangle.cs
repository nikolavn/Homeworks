using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Width can not be null or negative");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width can not be null or negative");
                }

                this.height = value;
            }
        }

        public override double Area
        {
            get { return this.Width * this.Height; }
        }

        public override double Perimeter
        {
            get { return 2 * (this.Width + this.Height); }

        }        
    }
}
