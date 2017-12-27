using System;

class Program
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();
        int side = int.Parse(Console.ReadLine());

        string result = String.Empty;
        switch (figure)
        {
            case "Square":
                result = CorDraw.DrawSquare(side);
                break;
            case "Rectangle":
                int side2 = int.Parse(Console.ReadLine());
                result = CorDraw.DrawRectangle(side, side2);
                break;
        }

        Console.WriteLine(result);
    }
}
