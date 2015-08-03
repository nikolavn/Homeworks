using System;


namespace Utilities
{
    /// <summary>
    /// Class that provides methods for performing geometrical calculations
    /// </summary>
    public class GeometryOperations
    {
        /// <summary>
        /// Method that calculates the area of triangle by given 3 sides.
        /// </summary>
        /// <param name="sideA">First side of triangle</param>
        /// <param name="sideB">Second side of triangle</param>
        /// <param name="sideC">Third side of triangle</param>
        /// <returns>Area of the triangle with the given sides.</returns>
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("All sides should be positive and greater than 0");
            }

            if(!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
            {
                throw new ArgumentException("Enteres sides do not form a triangle");
            }

            double s = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

            return area;
        }

        /// <summary>
        /// Method that calculates distance between 2 points by their coordinates.
        /// </summary>
        /// <param name="point1">Instance of the Point class</param>
        /// <param name="point2">Instance of the Point class</param>
        /// <returns>Distance between the two points.</returns>
        public static double CalculateDistanceBetweenPoints(Point point1, Point point2)
        {
            double xDifference = (point2.X - point1.X) * (point2.X - point1.X); 
            double yDifference = (point2.Y - point1.Y) * (point2.Y - point1.Y);

            double distance = Math.Sqrt(xDifference + yDifference);

            return distance;
        }

        /// <summary>
        /// Method that checks whether a line is horizontal.
        /// </summary>
        /// <param name="point1">Instance of the Point class</param>
        /// <param name="point2">Instance of the Point class</param>
        /// <returns>True if line is horizontal, false otherwise.</returns>
        public static bool isLineHorizontal(Point point1, Point point2)
        {
            bool isHorizontal = (point1.Y == point2.Y);

            return isHorizontal;
        }

        /// <summary>
        /// Method that checks whether a line is horizontal.
        /// </summary>
        /// <param name="point1">Instance of the Point class</param>
        /// <param name="point2">Instance of the Point class</param>
        /// <returns>True if line is horizontal, false otherwise.</returns>
        public static bool isLineVertical(Point point1, Point point2) 
        {
            bool isVertical = (point1.X == point2.X);

            return isVertical;
        }
    }
}
