using System;
using System.Collections.Generic;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        // Person=Money;Person=Money...
        string[] peopleArgs = Console.ReadLine()
            .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        var peopleDict = new Dictionary<string, Person>();

        foreach (var personArgs in peopleArgs)
        {
            // {Person}{Money}
            string[] personInfo = personArgs
                .Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

            string personName = personInfo[0];
            double personMoney = double.Parse(personInfo[1]);

            try
            {
                peopleDict.Add(personName, new Person(personName, personMoney));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        // Product=Cost;Product=Cost...
        string[] productsArgs = Console.ReadLine()
            .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        var productsDict = new Dictionary<string, Product>();

        foreach (var productArgs in productsArgs)
        {
            // {Product}{Cost}
            string[] productInfo = productArgs
                .Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

            string productName = productInfo[0];
            double productCost = double.Parse(productInfo[1]);

            try
            {
                productsDict.Add(productName, new Product(productName, productCost));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            string[] inputArgs = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string personName = inputArgs[0];
            string productName = inputArgs[1];

            try
            {
                peopleDict[personName].BuyProduct(productsDict[productName]);
                Console.WriteLine($"{personName} bought {productName}");
            }
            catch
            {
                Console.WriteLine($"{personName} can't afford {productName}");
            }
        }

        foreach (var person in peopleDict.Values)
        {
            Console.WriteLine(person);
        }
    }
}
