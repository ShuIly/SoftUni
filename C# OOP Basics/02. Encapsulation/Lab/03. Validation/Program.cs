﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            try
            {
                var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    double.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var bonus = double.Parse(Console.ReadLine());
        foreach (var person in persons)
        {
            person.IncreaseSalary(bonus);
            Console.WriteLine(person);
        }
    }
}
