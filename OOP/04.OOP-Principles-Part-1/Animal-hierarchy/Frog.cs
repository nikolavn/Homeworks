using System;

public class Frog : Animal, ISound
{
    public Frog(string name, byte age, Sex sex)
        : base(name, age, sex)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("{0} {1} says: Kvak-Kvak", this.GetType(), this.Name);
    }
}

