using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
			Queue<long> aliveBeehives = new Queue<long>();
			Queue<long> beehives = new Queue<long>
				(Console.ReadLine()
				.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(long.Parse)
				.ToArray());

			Queue<long> aliveHornets = new Queue<long>
				(Console.ReadLine()
				.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(long.Parse)
				.ToArray());

	        long sumHornetPower = aliveHornets.Sum();

	        while (beehives.Count > 0 && aliveHornets.Count > 0)
	        {
		        if (sumHornetPower <= beehives.Peek())
		        {
					if (sumHornetPower < beehives.Peek())
						aliveBeehives.Enqueue(beehives.Peek() - sumHornetPower);

			        sumHornetPower -= aliveHornets.Dequeue();
		        }

				beehives.Dequeue();
	        }

	        if (aliveBeehives.Count > 0 || beehives.Count > 0)
	        {
		        while (aliveBeehives.Count > 0)
			        Console.Write(aliveBeehives.Dequeue() + " ");

		        while (beehives.Count > 0)
			        Console.Write(beehives.Dequeue() + " ");
	        }
	        else if (aliveHornets.Count > 0)
	        {
		        while (aliveHornets.Count > 0)
			        Console.Write(aliveHornets.Dequeue() + " ");
	        }

	        Console.WriteLine();
        }
    }
}