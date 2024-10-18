using System;
using System.Linq;

namespace AbstractClass;

public static class Program
{
    public static void Main()
    {
        Car car1 = new Car
        {
            FactoryName = "BMW",
            Model = "M5",
            Color = "Black",
            DriveTime = 3,
            DrivePath = 180,
            DoorCount = 4,
            IsElectricCar = false
        };
        car1.GetInfo();

        Bicycle bicycle1 = new Bicycle
        {
            FactoryName = "Turbo",
            Model = "BMX",
            Color = "Black",
            DriveTime = 1.5m,
            DrivePath = 30,
            Type = "Mountain"
        };
        bicycle1.GetInfo();


    }

}
