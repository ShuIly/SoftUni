using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
			var numCount = new SortedDictionary<double, int>();
	        var nums = new Stack<double>
				(Console.ReadLine()
				.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.ToArray());

	        while (nums.Count > 0)
	        {
		        if (!numCount.ContainsKey(nums.Peek()))
			        numCount.Add(nums.Pop(), 1);
		        else
			        numCount[nums.Pop()]++;
	        }

	        string result = "";
	        foreach (var num in numCount)
	        {
		        result += $"{num.Key} - {num.Value} times\n";
	        }

	        Console.WriteLine(result);
        }
    }
}