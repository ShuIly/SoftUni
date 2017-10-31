using System;
using System.Collections.Generic;

namespace _04.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
	        var charCount = new SortedDictionary<char, int>();
			string input = Console.ReadLine();

	        foreach (char c in input)
	        {
		        if (!charCount.ContainsKey(c))
			        charCount.Add(c, 1);
		        else
			        charCount[c]++;
	        }

	        string result = "";
	        foreach (var c in charCount)
	        {
		        result += $"{c.Key}: {c.Value} time/s\n";
	        }

	        Console.WriteLine(result);
        }
    }
}