using System;
using System.Collections.Generic;
using System.Linq;

public enum Sex { Male, Female };

public class Animal:ISound
{
    private string name = null;
    private byte age = 0;
    private Sex sex = Sex.Male;

    public Animal(string name, byte age, Sex sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public Sex Sex
    {
        get
        {
            return this.sex;
        }
        set
        {
            this.sex = value;
        }
    }

    public byte Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
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

    public virtual void MakeSound()
    {
        Console.WriteLine("Galkadsaskdjiq");
    }

    public override string ToString()
    {
        return string.Format(
            "\nAnimal: {0}\nName: {1}\nAge: {2}\nSex: {3}",this.GetType(),this.Name,this.Age,this.Sex
            );
    }
}

