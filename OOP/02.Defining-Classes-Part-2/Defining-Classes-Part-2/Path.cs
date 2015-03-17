using System;
using System.Collections.Generic;

[Serializable]
class Path:IEnumerable<Point3D>
{
    private List<Point3D> path3D = new List<Point3D>();

    public List<Point3D> Path3D
    {
        get { return this.path3D; }
        set { this.path3D = value; }
    }

    public void AddPoint(Point3D point)
    {
        this.path3D.Add(point);
    }

    public IEnumerator<Point3D> GetEnumerator()
    {
        foreach (Point3D point in this.path3D)
        {
            yield return point;
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

