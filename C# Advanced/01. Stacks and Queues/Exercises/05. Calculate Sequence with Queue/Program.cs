using System;
using System.Collections.Generic;

namespace _05.Calculate_Sequence_with_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
			// With int Judge gives 60/100.
			Queue<decimal> numQueue = new Queue<decimal>
				(new []{decimal.Parse(Console.ReadLine())});

	        string answer = "";
	        for (int i = 0; i < 48; i++)
	        {
		        decimal currNum = numQueue.Peek();
		        numQueue.Enqueue(currNum + 1);
		        numQueue.Enqueue(2 * currNum + 1);
		        numQueue.Enqueue(currNum + 2);

		        answer += numQueue.Dequeue() + " ";
	        }

			// A little ugly but better than the queue having 2 more nums.
			answer += numQueue.Dequeue() + " " + numQueue.Dequeue();

	        Console.WriteLine(answer);
        }
    }
}