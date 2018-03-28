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
            // boxes.Add(new Box<int>(int.Parse(Console.ReadLine())));
            boxes.Add(new Box<string>(Console.ReadLine()));
        }

        int[] indices = Console.ReadLine()
            .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        GenericCollectionManager.SwapGenerics(boxes, indices[0], indices[1]);

        foreach (var box in boxes)
        {
            Console.WriteLine(box);
        }
    }
}
