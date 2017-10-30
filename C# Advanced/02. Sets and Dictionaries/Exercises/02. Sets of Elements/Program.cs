using System;
using System.Collections.Generic;

namespace _02.Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] inputTokens = Console.ReadLine()
				.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries);

	        int n = int.Parse(inputTokens[0]);
	        int m = int.Parse(inputTokens[1]);

			var nums = new HashSet<int>();
			var repeatableNums = new HashSet<int>();

	        for (int i = 0; i < n; i++)
	        {
		        nums.Add(int.Parse(Console.ReadLine()));
	        }
			
	        for (int i = 0; i < m; i++)
	        {
		        int num = int.Parse(Console.ReadLine());
		        if (nums.Contains(num))
			        repeatableNums.Add(num);
	        }

	        Console.WriteLine(string.Join(" ", repeatableNums));
        }
    }
}