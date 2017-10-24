using System;
using System.Collections.Generic;

namespace _06.Math_Potato
{
	class Program
	{
		// Simple algorithm for finding if number is prime.
		// Could have used Sieve of Eratosthenes but that's too much work.
		static bool IsPrime(int num)
		{
			if (num <= 1)
				return false;

			int sqrtNum = (int) Math.Sqrt(num);
			int incrementor = 0;

			for (int i = 2; i <= sqrtNum; i++)
			{
				if (num % i == 0)
					return false;
			}

			return true;
		}
		static void Main(string[] args)
		{
			var kidsQueue = new Queue<string>(Console.ReadLine().Split());
			int n = int.Parse(Console.ReadLine());
			int cycles = 1;

			while (kidsQueue.Count > 1)
			{
				for (int i = 1; i < n; i++)
				{
					kidsQueue.Enqueue(kidsQueue.Dequeue());
				}


				if (IsPrime(cycles))
					Console.WriteLine($"Prime {kidsQueue.Peek()}");
				else
					Console.WriteLine($"Removed {kidsQueue.Dequeue()}");

				cycles++;
			}

			Console.WriteLine($"Last is {kidsQueue.Dequeue()}");
		}
	}
}