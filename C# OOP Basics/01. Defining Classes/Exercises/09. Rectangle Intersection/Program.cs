using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var rectangles = new Dictionary<string, Rectangle>();

        string[] inputArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int rectCount = int.Parse(inputArgs[0]);
        int intersectChecks = int.Parse(inputArgs[1]);

        for (int i = 0; i < rectCount; i++)
        {
            string[] rectArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string id = rectArgs[0];
            double width = double.Parse(rectArgs[1]);
            double height = double.Parse(rectArgs[2]);
            double x = double.Parse(rectArgs[3]);
            double y = double.Parse(rectArgs[4]);

            rectangles.Add(id, new Rectangle(width, height, x, y));
        }

        for (int i = 0; i < intersectChecks; i++)
        {
            string[] checkArgs = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string firstRectID = checkArgs[0];
            string secondRectID = checkArgs[1];

            if (rectangles[firstRectID].IsIntersecting(rectangles[secondRectID]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
