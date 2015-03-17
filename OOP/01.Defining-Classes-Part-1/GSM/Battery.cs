using System;
using System.Collections.Generic;

public enum BatteryType { LiIon, NiMH, NiCd, LiPoly }

class Battery
{
    private string model = null;
    private uint hoursIdle = 0;
    private uint hoursTalk = 0;
    private BatteryType batteryType;    

    public Battery(string model)
    {
        this.model = model;
    }

    public Battery(string model, uint hoursTalk)
        : this(model)
    {
        this.hoursTalk = hoursTalk;
    }

    public Battery(string model, uint hoursTalk, uint hoursIdle)
        : this(model, hoursTalk)
    {
        this.hoursIdle = hoursIdle;
    }

    public Battery(string model, uint hoursTalk, uint hoursIdle, BatteryType batteryType)
        : this(model, hoursTalk, hoursIdle)
    {
        this.batteryType = batteryType;
    }

    public string Model
    {
        get { return model; }
        set 
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Battery model can not be null or empty.");
            }
            model = value; 
        }
    }

    public uint HoursIdle
    {
        get { return hoursIdle; }
        set { hoursIdle = value; }
    }

    public uint HoursTalk
    {
        get { return hoursTalk; }
        set { hoursTalk = value; }
    }

    public BatteryType BatteryType
    {
        get { return batteryType; }
        set { batteryType = value; }
    }
}

