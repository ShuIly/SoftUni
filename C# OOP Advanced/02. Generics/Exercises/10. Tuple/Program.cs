using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] firstInput = Console.ReadLine()
            .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        string[] secondInput = Console.ReadLine()
            .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        string[] thirdInput = Console.ReadLine()
            .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        var tuple1 = new Tuple<string, string>($"{firstInput[0]} {firstInput[1]}", firstInput[2]);
        var tuple2 = new Tuple<string, int>(secondInput[0], int.Parse(secondInput[1]));
        var tuple3 = new Tuple<int, double>(secondInput[0], int.Parse(secondInput[1]));
    }
}