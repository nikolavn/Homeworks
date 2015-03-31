using System;

class Square : Rectangle
{
    double Side { get; set; }

    public Square(double side)
        : base(side, side)
    {
        this.Side = side;
    }

    public override double CalculateSurface()
    {
        return this.Side * this.Side;
    }
}

