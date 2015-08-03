using System;

namespace CohesionAndCoupling
{
    class Point3D : Point
    {
        private double z;

        public Point3D(double xCoord, double yCoord, double zCoord)
            : base(xCoord, yCoord)
        {
            this.Z = zCoord;
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }
    }
}
