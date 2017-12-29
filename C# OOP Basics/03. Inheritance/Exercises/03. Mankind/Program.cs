using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Human> people = new List<Human>();

        string[] studentArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] workerArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        try
        {
            people.Add(new Student(studentArgs[0], studentArgs[1], studentArgs[2]));
            people.Add(new Worker(workerArgs[0], workerArgs[1], double.Parse(workerArgs[2]), double.Parse(workerArgs[3])));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        Console.WriteLine(String.Join("\n\n", people));
    }
}
