using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace _05.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
	        var phonebook = new Dictionary<string, string>();

	        while (true)
	        {
				string input = Console.ReadLine();

				if (input == "search")
					break;

		        string[] inputTokens = input
					.Split(new []{ '-' }, StringSplitOptions.RemoveEmptyEntries);

		        phonebook[inputTokens[0]] = inputTokens[1];
	        }

	        while (true)
	        {
		        string input = Console.ReadLine();

		        if (input == "stop")
					break;

				if (phonebook.ContainsKey(input))
					Console.WriteLine($"{input} -> {phonebook[input]}");
				else
					Console.WriteLine($"Contact {input} does not exist.");
	        }
        }
    }
}