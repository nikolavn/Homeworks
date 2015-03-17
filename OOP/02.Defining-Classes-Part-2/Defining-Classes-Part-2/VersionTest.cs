using System;
using System.Collections.Generic;
using System.Linq;

[VersionAttributes(2, 11)]
[VersionAttributes(2, 16)]
[VersionAttributes(3, 28)]

class VersionTest
{
    public static void RunTests()
    {
        Type type = typeof(VersionTest);
        object[] allAttributes = type.GetCustomAttributes(false);

        foreach (VersionAttributes  attribute in allAttributes)
        {
            Console.WriteLine("Version {0}.{1}",attribute.Major,attribute.Minor);
        }
    }
}

