using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _02.Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] input = Console.ReadLine()
				.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries);

	        int n = int.Parse(input[0]);
			int numPop = int.Parse(input[1]);
			int searchNum = int.Parse(input[2]);

			Stack<int> numStack = 
				new Stack<int>(Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.Take(n)
				.ToArray());

			for (int i = 0; i < numPop && numStack.Count > 0; ++i)
		        numStack.Pop();

	        if (numStack.Count == 0)
	        {
		        Console.WriteLine(0);
				return;
	        }

	        int minStackNum = int.MaxValue;
	        while (numStack.Count > 0)
	        {
		        int currNum = numStack.Pop();

		        if (currNum == searchNum)
		        {
			        Console.WriteLine("true");
					return;
		        }

		        if (minStackNum > currNum)
			        minStackNum = currNum;
	        }

	        Console.WriteLine(minStackNum);
        }
    }
}