using System;
using System.Linq;
using System.Collections.Generic;

namespace AbstractClass;

public class Car : Vehicle
{
    public byte _doorCount;
    public bool _isElectricCar;

    public byte DoorCount
    {
        get
        {
            return _doorCount;
        }
        set
        {
            if (value == 0)
            {
                Console.WriteLine("Car must have at least one door");

            }
            else
            {
                _doorCount = value;
            }
        }
    }
    public bool IsElectricCar
    {
        get
        {
            return _isElectricCar;
        }
        set
        {
            _isElectricCar = value;
        }
    }
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Door Count: {DoorCount}");
        Console.WriteLine($"Is Electric Car: {IsElectricCar}");
        Console.WriteLine($"Nature Harm: {DefineNatureHarmness()}");
    }
    public override string DefineNatureHarmness()
    {
        if (IsElectricCar)
        {
            return "Low harm";
        }
        else
        {
            return "High harm";
        }
    }

}




