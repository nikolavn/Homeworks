using System;
using System.Collections.Generic;

class GSM
{
    private string model = null;
    private string manufacturer = null;
    private uint price = 0;
    private string owner = null;
    private Battery battery = new Battery("MonBat");    
    private Display display = new Display(5);
    private static GSM iPhone4S = new GSM("iPhone 4S", "Apple", 1000, "Pesho", new Battery("MonBat", 100, 350, BatteryType.LiIon), new Display(9, 16000000));
    private List<Call> callHistory = new List<Call>();

    public GSM(string model, string manufacturer)
    {
        this.model = model;
        this.manufacturer = manufacturer;
    }

    public GSM(string model, string manufacturer, uint price)
        : this(model, manufacturer)
    {
        this.price = price;
    }

    public GSM(string model, string manufacturer, uint price, string owner)
        : this(model, manufacturer, price)
    {
        this.owner = owner;
    }

    public GSM(string model, string manufacturer, uint price, string owner, Battery battery)
        : this(model, manufacturer, price, owner)
    {
        this.battery = battery;
    }

    public GSM(string model, string manufacturer, uint price, string owner, Battery battery, Display display)
        : this(model, manufacturer, price, owner, battery)
    {
        this.display = display;
    }

    public string Model
    {
        get { return model; }
        set 
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("GSM model can not be null or empty.");
            }
            model = value; 
        }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set 
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("GSM manufacturer can not be null or empty.");
            }
            manufacturer = value; 
        }
    }

    public uint Price
    {
        get { return price; }
        set 
        {
            try
            {
                price = value;
            }
            catch(OverflowException)
            {
                Console.WriteLine("GSM price should be between {0} and {1}",0,uint.MaxValue);
            }
        }
    }

    public string Owner
    {
        get { return owner; }
        set 
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("GSM owner can not be null or empty.");
            }
            owner = value; 
        }
    }

    internal Battery Battery
    {
        get { return battery; }
        set { battery = value; }
    }

    internal Display Display
    {
        get { return display; }
        set { display = value; }
    }

    internal static GSM IPhone4S
    {
        get { return GSM.iPhone4S; }
        set { GSM.iPhone4S = value; }
    }

    public List<Call> CallHistory 
    {
        get { return this.callHistory; } 
    }

    public void AddCall(Call call)
    {
        this.callHistory.Add(call);
    }

    public void DeleteCall(Call call)
    {
        if (this.callHistory.Count==0)
        {
            Console.WriteLine("Call history is empty.");
        }
        this.callHistory.Remove(call);
    }

    public void ClearHistory()
    {
        this.callHistory.Clear();
    }

    public double CalculateCallsPrice(double callPrice)
    {
        double totalPrice = 0;

        foreach (var call in this.callHistory)
        {
            totalPrice += ((call.Duration / 60) * callPrice);
        }

        return totalPrice;
    }
        
    public override string ToString()
    {
        return string.Format(
            "\nGSM Info:" +
            "\nModel: {0}" +
            "\nManufacturer: {1}"+
            "\nPrice: {2:C2}" +
            "\nOwner: {3}" + 
            "\n\nBattery Info:" +
            "\nModel: {4}" +
            "\nHours Talk: {5} hrs" +
            "\nHours Idle: {6} hrs" +
            "\nBatter Type: {7}" +
            "\n\nDisplay Info:" +
            "\nSize: {8} cm." +
            "\nNumber of colors: {9}",
            this.Model, this.Manufacturer, this.Price, this.Owner, 
            this.Battery.Model,this.Battery.HoursTalk,this.Battery.HoursIdle,this.Battery.BatteryType,
            this.Display.Size,this.Display.NumberOfColors
            );
    }
}

