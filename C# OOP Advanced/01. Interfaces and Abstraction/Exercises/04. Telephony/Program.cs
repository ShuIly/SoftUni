using System;

class Program
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] websites = Console.ReadLine().Split();

        Smartphone smartphone = new Smartphone();

        foreach (var number in numbers)
        {
            try
            {
                Console.WriteLine(smartphone.Call(number));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (var website in websites)
        {
            try
            {
                Console.WriteLine(smartphone.Browse(website));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
