using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var people = new Dictionary<string, Person>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            string[] inputArgs = input
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string personName = inputArgs[0];

            if (!people.ContainsKey(personName))
            {
                people.Add(personName, new Person(personName));
            }

            string personArg = inputArgs[1];
            switch (personArg)
            {
                case "company":
                    Company company = new Company(inputArgs[2], inputArgs[3], double.Parse(inputArgs[4]));
                    people[personName].Company = company;
                    break;
                case "pokemon":
                    Pokemon pokemon = new Pokemon(inputArgs[2], inputArgs[3]);
                    people[personName].Pokemons.Add(pokemon);
                    break;
                case "parents":
                    Parent parent = new Parent(inputArgs[2], inputArgs[3]);
                    people[personName].Parents.Add(parent);
                    break;
                case "children":
                    Child child = new Child(inputArgs[2], inputArgs[3]);
                    people[personName].Children.Add(child);
                    break;
                case "car":
                    Car car = new Car(inputArgs[2], int.Parse(inputArgs[3]));
                    people[personName].Car = car;
                    break;
            }
        }

        string inputName = Console.ReadLine();
        Console.WriteLine(people[inputName]);
    }
}
