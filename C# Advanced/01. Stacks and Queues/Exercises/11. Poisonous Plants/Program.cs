using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
	        int n = int.Parse(Console.ReadLine());
			Queue <int> plants = new Queue<int>(Console.ReadLine()
				.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray()
				.Reverse());

	        int days = 0;
	        while (true)
	        {
		        int count = plants.Count;
				for (int i = 0; i < count; i++)
				{
					int currPlant = plants.Dequeue();

					if (i == count - 1 || currPlant <= plants.Peek())
						plants.Enqueue(currPlant);
				}

		        if (count == plants.Count)
					break;

		        days++;
	        }

	        Console.WriteLine(days);
        }
    }
}