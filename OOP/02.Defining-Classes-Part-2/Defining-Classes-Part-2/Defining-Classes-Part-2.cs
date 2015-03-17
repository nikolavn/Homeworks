using System;
using System.Collections.Generic;

class DefiningClassesPart2
{
    static void Main()
    {
        Point3D point1 = new Point3D(1, 2, 3);
        Point3D point2 = new Point3D(4, 5, 6);

        Console.WriteLine(Points3DOperations.CalculateDistance(point1, point2));

        Path path = new Path();

        path.AddPoint(point1);
        path.AddPoint(point2);

        PathStorage.SavePath(path, "../../", "path.txt");
        Path myPath = PathStorage.LoadPath("../../path.txt");

        foreach (var point in myPath)
        {
            Console.WriteLine(point);
        }

        GenericList<int> test = new GenericList<int>(6) { 1, 2, 3, 5, 6, 7 };

        test.InsertAt(3, 4);
        test.InsertAt(7, 8);

        foreach (var number in test)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        test.RemoveAt(5);

        foreach (var number in test)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();

        Console.WriteLine(test.IndexOf(4));

        Console.WriteLine(test.Min());

        Console.WriteLine(test.Max());

        Console.WriteLine(test[6]);

        test.ClearList();

        foreach (var item in test)
        {
            Console.WriteLine(item);
        }

        Matrix<int> matrix1 = new Matrix<int>(2);
        Matrix<int> matrix2 = new Matrix<int>(2);

        matrix1[1, 1] = 3;
        matrix2[0, 0] = 5;

        Matrix<int> result = matrix1 + matrix2;

        result[0, 1] = 2;
        result[1,0] = 16;

        if (result)
        {
            result.Print();
        }

        VersionTest.RunTests();
    }
}

