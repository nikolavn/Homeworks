using System;

public class Tomcat : Animal, ISound
{
    public Tomcat(string name, byte age)
        : base(name, age, Sex.Male)
    {
        
    }

    public override void MakeSound()
    {
        Console.WriteLine("{0} {1} says: Hiss-Hiss", this.GetType(), this.Name);
    }
}

