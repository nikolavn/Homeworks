using System;
using System.Collections.Generic;
using System.Linq;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum |
    AttributeTargets.Interface | AttributeTargets.Method, AllowMultiple = true)]

public class VersionAttributes : System.Attribute
{
    public int Major { get; set; }
    public int Minor { get; set; }

    public VersionAttributes(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
    }
}
