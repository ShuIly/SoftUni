using System;
using System.Collections.Generic;

namespace _06.A_Miners_Task
{
    class Program
    {
        static void Main(string[] args)
        {
			var resourcesQuantity = new Dictionary<string, int>();

	        while (true)
	        {
		        string resource = Console.ReadLine();

				if (resource == "stop")
					break;

		        int quantity = int.Parse(Console.ReadLine());

		        if (!resourcesQuantity.ContainsKey(resource))
			        resourcesQuantity.Add(resource, quantity);
		        else
			        resourcesQuantity[resource] += quantity;
	        }

	        string result = "";
	        foreach (var resource in resourcesQuantity)
	        {
		        result += $"{resource.Key} -> {resource.Value}\n";
	        }

	        Console.WriteLine(result);
        }
    }
}