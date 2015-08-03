using System;

namespace CohesionAndCoupling
{
    class GeometryUtilities
    {
        public static double CalcDistance2D(double point1X,double point1Y,double point2X,double point2Y)
        {
            double xComponent = (point2X - point1X) * (point2X - point1X);
            double yComponent = (point2Y - point1Y) * (point2Y - point1Y);

            double distance = Math.Sqrt(xComponent + yComponent);
            return distance;
        }

        public static double CalcDistance3D(double point1X, double point1Y,double point1Z, double point2X, double point2Y,double point2Z)
        {
            double xComponent = (point2X - point1X) * (point2X - point1X);
            double yComponent = (point2Y - point1Y) * (point2Y - point1Y);
            double zComponent = (point2Z - point1Z) * (point2Z - point1Z);

            double distance = Math.Sqrt(xComponent + yComponent + zComponent);
            return distance;
        }
    }
}
