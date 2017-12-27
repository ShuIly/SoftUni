using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>();
        var partialInfo = new List<string>();

        string searchedPersonInfo = Console.ReadLine();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            if (!input.Contains('-'))
            {
                string[] inputTokens = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string personName = inputTokens[0] + " " + inputTokens[1];
                string personBirthDate = inputTokens[2];

                people.Add(new Person(personName, personBirthDate));
            }
            else
            {
                partialInfo.Add(input);
            }
        }

        foreach (var info in partialInfo)
        {
            string[] inputTokens = info
                .Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

            Person parent;
            Person child;

            if (inputTokens[0].Contains("/"))
            {
                string parentBirthDate = inputTokens[0];

                parent = people
                    .First(p => p.BirthDate == parentBirthDate);
            }
            else
            {
                string parentName = inputTokens[0];

                parent = people
                    .First(p => p.Name == parentName);
            }

            if (inputTokens[1].Contains("/"))
            {
                string childBirthDate = inputTokens[1];

                child = people
                    .First(p => p.BirthDate == childBirthDate);
            }
            else
            {
                string childName = inputTokens[1];

                child = people
                    .First(p => p.Name == childName);
            }

            child.Parents.Add(parent);
            parent.Children.Add(child);
        }

        Person searchedPerson;

        if (searchedPersonInfo.Contains('/'))
        {
            searchedPerson = people
                .First(p => p.BirthDate == searchedPersonInfo);
        }
        else
        {
            searchedPerson = people
                .First(p => p.Name == searchedPersonInfo);
        }

        string result = searchedPerson +
                        "Parents:\n" +
                        String.Join(String.Empty, searchedPerson.Parents) +
                        "Children:\n" +
                        String.Join(String.Empty, searchedPerson.Children);

        Console.WriteLine(result);
    }
}
