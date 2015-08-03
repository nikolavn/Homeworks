using System;

namespace CohesionAndCoupling
{
    class Cuboid
    {
        private Point3D entryPoint;
        private double width;
        private double height;
        private double depth;

        public Cuboid(Point3D entryPoint, double width, double height, double depth)
        {
            this.EntryPoint = entryPoint;
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public Point3D EntryPoint
        {
            get;
            set;
        }
        
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width can not be null or empty");
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
                    throw new ArgumentException("Height can not be null or empty");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Depth can not be null or empty");
                }

                this.depth = value;
            }
        }

        public double Volume
        {
            get { return this.Width * this.Height * this.Depth; }
        }

        public double DiagonalXYZ
        {
            get { return GeometryUtilities.CalcDistance3D(this.EntryPoint.X,this.EntryPoint.Y,this.EntryPoint.Z,this.Width, this.Height, this.Depth); }
        }

        public double DiagonalXY
        {
            get { return GeometryUtilities.CalcDistance2D(this.EntryPoint.X,this.EntryPoint.Y, this.Width, this.Height); }
        }

        public double DiagonalXZ
        {
            get { return GeometryUtilities.CalcDistance2D(this.EntryPoint.X,this.EntryPoint.Y,this.Width, this.Depth); }
        }

        public double DiagonalYZ
        {
            get { return GeometryUtilities.CalcDistance2D(this.EntryPoint.X,this.EntryPoint.Y,this.Height, this.Depth); }
        }
    }
}
