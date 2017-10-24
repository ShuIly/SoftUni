using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HotPotato
{
	class Program
	{
		static void Main(string[] args)
		{
			var kidsQueue = new Queue<string>(Console.ReadLine().Split());
			int n = int.Parse(Console.ReadLine());

			while (kidsQueue.Count > 1)
			{
				for (int i = 1; i < n; i++)
				{
					kidsQueue.Enqueue(kidsQueue.Dequeue());
				}

				Console.WriteLine($"Removed {kidsQueue.Dequeue()}");
			}

			Console.WriteLine($"Last is {kidsQueue.Dequeue()}");
		}
	}
}