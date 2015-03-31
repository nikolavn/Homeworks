using System;

class Triangle : Shape
{
    double Width { get; set; }
    double Height { get; set; }

    public Triangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public override double CalculateSurface()
    {
        return (this.Height * this.Width) / 2;
    }
}

