using System;

[Serializable]
public struct Point3D
{
    static readonly Point3D coordinateSystemStart = new Point3D(0, 0, 0);
    //private int xCoord;
    //private int yCoord;
    //private int zCoord;

    public Point3D(int xCoord, int yCoord, int zCoord)
        : this()
    {
        this.XCoord = xCoord;
        this.YCoord = yCoord;
        this.ZCoord = zCoord;
    }

    public int XCoord { get; set; }
    public int YCoord { get; set; }
    public int ZCoord { get; set; }

    public static Point3D CoordinateSystemStart
    {
        get { return Point3D.coordinateSystemStart; }
    }

    public override string ToString()
    {
        return string.Format(
            "Point [X= {0}, Y= {1}, Z= {2}]",
            this.XCoord, this.YCoord, this.ZCoord
            );
    }
}

