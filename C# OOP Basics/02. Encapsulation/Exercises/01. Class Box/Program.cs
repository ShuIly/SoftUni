﻿using System;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());

        var length = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        Box box = new Box(length, width, height);

        Console.WriteLine($"Surface Area - {box.SurfaceArea:F2}");
        Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea:F2}");
        Console.WriteLine($"Volume - {box.Volume:F2}");
    }
}
