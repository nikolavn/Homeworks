using System;

public class Kitten : Animal, ISound
{
    public Kitten(string name, byte age)
        : base(name, age,Sex.Female)
    {
        
    }

    public override void MakeSound()
    {
        Console.WriteLine("{0} {1} says: Purr-Purr", this.GetType(), this.Name);
    }
}

