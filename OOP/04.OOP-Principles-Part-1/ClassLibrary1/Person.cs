using System;
using System.Collections.Generic;

class Person
{
    private string name = null;

    public Person(string personName)
    {
        this.Name = personName;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }
}

