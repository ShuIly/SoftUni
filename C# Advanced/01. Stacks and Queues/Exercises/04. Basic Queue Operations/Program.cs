using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Basic_Queue_Operations
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

			Queue<int> numQueue = 
				new Queue<int>(Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.Take(n)
				.ToArray());

			for (int i = 0; i < numPop && numQueue.Count > 0; ++i)
		        numQueue.Dequeue();

	        if (numQueue.Count == 0)
	        {
		        Console.WriteLine(0);
				return;
	        }

	        int minQueueNum = int.MaxValue;
	        while (numQueue.Count > 0)
	        {
		        int currNum = numQueue.Dequeue();

		        if (currNum == searchNum)
		        {
			        Console.WriteLine("true");
					return;
		        }

		        if (minQueueNum > currNum)
			        minQueueNum = currNum;
	        }

	        Console.WriteLine(minQueueNum);
        }
    }
}