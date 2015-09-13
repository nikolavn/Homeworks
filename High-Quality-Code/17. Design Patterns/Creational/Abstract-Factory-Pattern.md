#[Abstract Factory](https://sourcemaking.com/design_patterns/abstract_factory)

Този шаблон е подобен на **Simple Factory** и **Factory** шаблоните с тази разлика, че **Abstract Factory** предоставя интерфейс за създаване на няколко свързани обекта ("фамилия от обекти") вместо само един. Самите обекти могат или да са абстрактни или да не са, като потребителят използващ интерфейса не знае конкретния им клас.

**Abstract Factory** се използва:

* В системи, които се променят често

Шаблонът предоставя гъвкав механизъм, чрез който да се подменят различни множества от обекти.

###Code sample
```csharp
using System;
using System.Collections.Generic;
using System.Text;

public class MainApp
{
    public static void Main()
    {
        var furnitureFactory = new FamousSwedishChairManufacturer();
        var myShop = new FurnitureShop(furnitureFactory);

        var kitchenChair = myShop.OrderKitchenChair();
        Console.WriteLine(kitchenChair.ToString());

        var officeChair = myShop.OrderOfficeChair();
        Console.WriteLine(officeChair.ToString());

        var anotherFurnitureFactory = new InfamousImaginaryChairManufacturer();
        myShop = new FurnitureShop(anotherFurnitureFactory);

        var anotherKitchenChair = myShop.OrderKitchenChair();
        Console.WriteLine(anotherKitchenChair.ToString());

        var anotherOfficeChair = myShop.OrderOfficeChair();
        Console.WriteLine(anotherOfficeChair.ToString());
    }
}

public abstract class Chair
{
    private readonly IReadOnlyCollection<string> features;

    protected Chair(IEnumerable<string> features)
    {
        this.features = new List<string>(features);
    }

    protected abstract string Name { get; }

    private IEnumerable<string> Features
    {
        get { return this.features; }
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(this.Name);
        stringBuilder.AppendLine(string.Join(", ", this.Features));
        return stringBuilder.ToString();
    }

}

public class KitchenChair : Chair
{
    private readonly string manufacturer;

    public KitchenChair(IEnumerable<string> features, string manufacturer)
        : base(features)
    {
        this.manufacturer = manufacturer;
    }

    protected override string Name
    {
        get
        {
            return string.Format("Kitchen chair manufactured by: {0}", this.manufacturer);
        }
    }
}

public class OfficeChair : Chair
{
    private readonly string manufacturer;

    public OfficeChair(IEnumerable<string> features, string manufacturer)
        : base(features)
    {
        this.manufacturer = manufacturer;
    }

    protected override string Name
    {
        get
        {
            return string.Format("Office chair manufactured by: {0}", this.manufacturer);
        }
    }
}

public abstract class ChairManufacturer
{
    public abstract KitchenChair ManufactureKitchenChair();
    public abstract OfficeChair ManufactureOfficeChair();
}

public class FamousSwedishChairManufacturer : ChairManufacturer
{
    private const string Name = "FSCM";

    public override KitchenChair ManufactureKitchenChair()
    {
        var features = new List<string> { "padded seat", "padded back" };
        var chair = new KitchenChair(features, Name);
        return chair;
    }

    public override OfficeChair ManufactureOfficeChair()
    {
        var features = new List<string> { "white leather", "comfort armrests", "wheels" };
        var chair = new OfficeChair(features, Name);
        return chair;
    }
}

public class InfamousImaginaryChairManufacturer : ChairManufacturer
{
    private const string Name = "IICM";

    public override KitchenChair ManufactureKitchenChair()
    {
        var features = new List<string> { "thorned seat", "no back" };
        var chair = new KitchenChair(features, Name);
        return chair;
    }

    public override OfficeChair ManufactureOfficeChair()
    {
        var features = new List<string> { "all wooden framework", "stiff back", "bolted to ground" };
        var chair = new OfficeChair(features, Name);
        return chair;
    }
}

public class FurnitureShop
{
    private readonly ChairManufacturer supplier;

    public FurnitureShop(ChairManufacturer manufacturer)
    {
        this.supplier = manufacturer;
    }

    public KitchenChair OrderKitchenChair()
    {
        return this.supplier.ManufactureKitchenChair();
    }

    public OfficeChair OrderOfficeChair()
    {
        return this.supplier.ManufactureOfficeChair();
    }
}
```
