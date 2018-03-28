using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Box<string>> boxes = new List<Box<string>>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            // boxes.Add(new Box<double>(double.Parse(Console.ReadLine())));
            boxes.Add(new Box<string>(Console.ReadLine()));
        }

        Box<string> compareItem = new Box<string>(Console.ReadLine());
        // Box<double> compareItem = new Box<double>(double.Parse(Console.ReadLine()));

        int result = GenericCollectionComparer.GetBiggerElementsCountFromList(boxes, compareItem);

        Console.WriteLine(result);
    }
}
