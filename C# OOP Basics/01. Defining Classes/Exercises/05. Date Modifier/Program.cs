using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "yyyy MM dd", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "yyyy MM dd", CultureInfo.InvariantCulture);

        DateModifier dm = new DateModifier(firstDate, secondDate);

        Console.WriteLine(dm.DayDifference);
    }
}
