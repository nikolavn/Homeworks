using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileUtilities.GetFileExtension("example"));
            Console.WriteLine(FileUtilities.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.new.pdf"));


            Console.WriteLine("Distance in the 2D space = {0:f2}",
                GeometryUtilities.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                GeometryUtilities.CalcDistance3D(5, 2, -1, 3, -6, 4));


            Point3D cuboidStartPoint = new Point3D(0, 0, 0);

            Cuboid cuboid = new Cuboid(cuboidStartPoint, 3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", cuboid.Volume);
            Console.WriteLine("Diagonal XYZ = {0:f2}", cuboid.DiagonalXYZ);
            Console.WriteLine("Diagonal XY = {0:f2}", cuboid.DiagonalXY);
            Console.WriteLine("Diagonal XZ = {0:f2}", cuboid.DiagonalXZ);
            Console.WriteLine("Diagonal YZ = {0:f2}", cuboid.DiagonalYZ);
        }
    }
}
