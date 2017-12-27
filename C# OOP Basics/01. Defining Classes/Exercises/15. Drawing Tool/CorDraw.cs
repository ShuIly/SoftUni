using System;
using System.Text;

public static class CorDraw
{
    public static string DrawSquare(int side)
    {
        StringBuilder result = new StringBuilder();

        result.Append($"|{new string('-', side)}|\n");

        int count = side - 2;
        for (int i = 0; i < count; i++)
        {
            result.Append($"|{new string(' ', side)}|\n");
        }

        result.Append($"|{new string('-', side)}|\n");

        return result.ToString();
    }

    public static string DrawRectangle(int side1, int side2)
    {
        StringBuilder result = new StringBuilder();

        result.Append($"|{new string('-', side1)}|\n");

        int count = side2 - 2;
        for (int i = 0; i < count; i++)
        {
            result.Append($"|{new string(' ', side1)}|\n");
        }

        result.Append($"|{new string('-', side1)}|\n");

        return result.ToString();
    }
}
