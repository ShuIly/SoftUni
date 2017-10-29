using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Academy_Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
	        var studentGrades = new SortedDictionary<string, double>();
	        int n = int.Parse(Console.ReadLine());

	        for (int i = 0; i < n; i++)
	        {
				studentGrades.Add(Console.ReadLine(), 
					Console.ReadLine()
					.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(double.Parse)
					.ToArray()
					.Average());
	        }

	        string result = "";
	        foreach (var student in studentGrades)
	        {
		        result += $"{student.Key} is graduated with {student.Value}\n";
	        }

	        Console.WriteLine(result);
        }
    }
}