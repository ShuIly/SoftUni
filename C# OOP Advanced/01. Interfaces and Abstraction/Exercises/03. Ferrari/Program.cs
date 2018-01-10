using System;

class Program
{
    static void Main()
    {
        Ferrari ferrari = new Ferrari(Console.ReadLine());
        Console.WriteLine(ferrari);
        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }
    }
}
