using System;
using System.Linq;
using System.Collections.Generic;

namespace AbstractClass;

public abstract class Vehicle
{
    //fields
    public string _factoryName;
    public string _model;
    public string _color;
    public decimal _driveTime;
    public decimal _drivePath;
    private decimal _averageSpeed;

    //properties
    public string FactoryName
    {
        get { return _factoryName; }
        set { _factoryName = value; }
    }

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public decimal DriveTime
    {
        get { return _driveTime; }
        set
        {
            if (value > 0)
                _driveTime = value;
            else
                Console.WriteLine("Drive time must be greater than 0");
        }
    }

    public decimal DrivePath
    {
        get { return _drivePath; }
        set
        {
            if (value > 0)
                _drivePath = value;
            else
                Console.WriteLine("Drive path must be greater than 0");
        }
    }


    public void AverageSpeed()
    {
        _averageSpeed = DrivePath / DriveTime;
        Console.WriteLine($"Average speed:{_averageSpeed}");

    }
    public virtual void GetInfo()
    {
        Console.WriteLine($"Factory Name: {FactoryName}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Drive Time: {DriveTime} hours");
        Console.WriteLine($"Drive Path: {DrivePath} km");
        Console.WriteLine($"Average Speed: {AverageSpeed} km/h");

    }
    public override string ToString()
    {
        return $"{FactoryName} {Model}";
    }
    public abstract string DefineNatureHarmness();
}

