using System;
using System.Collections;
using System.Collections.Generic;

abstract class Shape : IEnumerable<Shape>
{
    //public abstract double Width { get; set; }

    //public abstract double Height { get; set; }

    //public Shape(double width, double height)
    //{
    //    this.Width = width;
    //    this.Height = height;
    //}

    public abstract double CalculateSurface();

    IEnumerator IEnumerable.GetEnumerator()
    {
        yield return this;
    }

    public IEnumerator<Shape> GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

