using System;
using System.Collections.Generic;

namespace _03.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
	        var elements = new HashSet<string>();
	        int n = int.Parse(Console.ReadLine());

	        for (int i = 0; i < n; i++)
	        {
		        string[] inputTokens = Console.ReadLine()
					.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries);

		        foreach (string inputToken in inputTokens)
		        {
			        elements.Add(inputToken);
		        }
	        }

	        Console.WriteLine(string.Join(" ", elements));
        }
    }
}