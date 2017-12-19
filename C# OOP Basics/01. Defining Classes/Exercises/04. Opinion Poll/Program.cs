using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var peopleDict = new Dictionary<string, Person>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] inputArgs = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string name = inputArgs[0];
            int age = int.Parse(inputArgs[1]);

            peopleDict.Add(name, new Person(name, age));
        }

        foreach (var person in peopleDict.Values
            .Where(p => p.age > 30)
            .OrderBy(p => p.name))
        {
            Console.WriteLine(person);
        }
    }
}