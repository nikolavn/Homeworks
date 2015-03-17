using System;
using System.Collections.Generic;

class Display
{
    private float size = 0F;
    private ulong numberOfColors = 0;    

    public Display(float size)
    {
        this.size = size;
    }

    public Display(float size, ulong numberOfColors)
        : this(size)
    {
        this.numberOfColors = numberOfColors;
    }

    public float Size
    {
        get { return size; }
        set 
        {
            if (value<0)
            {
                throw new ArgumentException("Display Size can not be negative.");
            }
            size = value; 
        }
    }

    public ulong NumberOfColors
    {
        get { return numberOfColors; }
        set { numberOfColors = value; }
    }
}

