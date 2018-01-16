using System;

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

        var tuple1 = new Threeuple<string, string, string>($"{firstInput[0]} {firstInput[1]}", firstInput[2], firstInput[3]);
        var tuple2 = new Threeuple<string, int, bool>(secondInput[0], int.Parse(secondInput[1]), secondInput[2] == "drunk");
        var tuple3 = new Threeuple<string, double, string>(thirdInput[0], double.Parse(thirdInput[1]), thirdInput[2]);

        Console.WriteLine(tuple1 + "\n" + tuple2 + "\n" + tuple3);
    }
}
