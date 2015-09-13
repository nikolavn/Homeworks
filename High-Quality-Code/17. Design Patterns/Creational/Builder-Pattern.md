#[Builder](https://sourcemaking.com/design_patterns/builder)

Използва се за разделяне на сложната логика по създаването на обект от конкретното му представяне. По този начин могат да се създават обекти с различно представяне използвайки едни и същи стъпки. Самите стъпки са капсулирани.

1.**Builder** шаблонът решава 3 основни проблема:

  * Скрива от потребителя всички параметри нужни за създаването на конкретен обект
  * Енкапсулира стъпките и техният ред, така че да не трябва да се помни
  * Скрива от потребителя всички възможни представяния на даден обект

2.Шаблонът има следните елементи:

  * **Director** – дефинира точната последователност от стъпки. Използва **Builder**.
  * **Builder** – дефинира всички стъпки. Използва се от **Concrete Builder**.
  * **Concrete Builder** – определя изпълнението. Имплементира **Director**.
  * **Product** – създава се от **Concrete Builder**. Продуктите са от еднакъв тип, но съдържат различни данни.


###Code sample
```csharp
using System;
using System.Collections.Generic;

public class MainApp
{
    public static void Main()
    {
        IVelocipedeConstructor bikeShop = new VelocipedeConstructor();

        VelocipedeBuilder myVelocipede = new UnicycleBuilder();
        bikeShop.Construct(myVelocipede);
        myVelocipede.Velocipede.Describe();

        myVelocipede = new TricycleBuilder();
        bikeShop.Construct(myVelocipede);
        myVelocipede.Velocipede.Describe();
    }
}

public interface IVelocipedeConstructor
{
    void Construct(VelocipedeBuilder velocipede);
}

public class VelocipedeConstructor : IVelocipedeConstructor
{
    public void Construct(VelocipedeBuilder velocipede)
    {
        velocipede.BuildFrame();
        velocipede.AddWheels();
        velocipede.AddChain();
        velocipede.AddPedals();
        velocipede.AddSeat();
    }
}

public abstract class VelocipedeBuilder
{
    public Velocipede Velocipede { get; set; }

    public abstract void BuildFrame();
    public abstract void AddWheels();
    public abstract void AddChain();
    public abstract void AddPedals();
    public abstract void AddSeat();
}

public class UnicycleBuilder : VelocipedeBuilder
{
    public UnicycleBuilder()
    {
        this.Velocipede = new Velocipede("Unicycle");
    }

    public override void BuildFrame()
    {
        this.Velocipede.AddPart("Frame", "Unicycle frame");
    }

    public override void AddWheels()
    {
        this.Velocipede.AddPart("Wheels", "1");
    }

    public override void AddChain()
    {
        this.Velocipede.AddPart("Chain", "Yes");
    }

    public override void AddPedals()
    {
        this.Velocipede.AddPart("Pedals", "Yes");
    }

    public override void AddSeat()
    {
        this.Velocipede.AddPart("Seat", "Yes");
    }

}

public class TricycleBuilder : VelocipedeBuilder
{
    public TricycleBuilder()
    {
        this.Velocipede = new Velocipede("Tricycle");
    }

    public override void BuildFrame()
    {
        this.Velocipede.AddPart("Frame", "Tricycle frame");
    }

    public override void AddWheels()
    {
        this.Velocipede.AddPart("Wheels", "3");
    }

    public override void AddChain()
    {
        this.Velocipede.AddPart("Chain", "No");
    }

    public override void AddPedals()
    {
        this.Velocipede.AddPart("Pedals", "Yes");
    }

    public override void AddSeat()
    {
        this.Velocipede.AddPart("Seat", "Yes");
    }

}

public class Velocipede
{
    private readonly string velocipedeType;
    private readonly Dictionary<string, string> parts = new Dictionary<string, string>();

    public Velocipede(string velocipedeType)
    {
        this.velocipedeType = velocipedeType;
    }

    public void AddPart(string name, string description)
    {
        this.parts.Add(name, description);
    }

    public void Describe()
    {
        Console.WriteLine("--------============--------");
        Console.WriteLine("Velocipede Type: {0}", this.velocipedeType);
        foreach (var part in this.parts)
        {
            Console.WriteLine("{0} --> {1}", part.Key, part.Value);
        }
    }
}
```
