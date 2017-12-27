using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var cats = new Dictionary<string, Cat>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            string[] catArgs = input
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string catType = catArgs[0];
            string catName = catArgs[1];

            switch (catType)
            {
                case "Siamese":
                    int earSize = int.Parse(catArgs[2]);
                    cats.Add(catName, new Siamese(catName, earSize));
                    break;
                case "Cymric":
                    double furLength = double.Parse(catArgs[2]);
                    cats.Add(catName, new Cymric(catName, furLength));
                    break;
                case "StreetExtraordinaire":
                    int meowDecibels = int.Parse(catArgs[2]);
                    cats.Add(catName, new StreetExtraordinaire(catName, meowDecibels));
                    break;
            }
        }

        string searchedCatName = Console.ReadLine();
        Cat searchedCat = cats[searchedCatName];

        Console.WriteLine(searchedCat);
    }
}
