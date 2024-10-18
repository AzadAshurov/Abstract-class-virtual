using System;
using System.Linq;
using System.Collections.Generic;

namespace AbstractClass;

public class Bicycle : Vehicle
{
    public string Type { get; set; }


    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Bicycle Type: {Type}");
        Console.WriteLine($"Nature Harm: {DefineNatureHarmness()}");
    }
    public override string DefineNatureHarmness()
    {
        return "No harm";
    }

}
