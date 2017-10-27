using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
			Queue<int> fuelLeft = new Queue<int>();
			int n = int.Parse(Console.ReadLine());

	        for (int i = 0; i < n; i++)
	        {
				int[] currPumpInfo = Console.ReadLine()
					.Split()
					.Select(int.Parse)
					.ToArray();

				fuelLeft.Enqueue(currPumpInfo[0] - currPumpInfo[1]);
	        }

			// For every element in the Queue we test if
			// we can make a full circle without running out
			// of fuel.
	        for (int i = 0; i < n; i++)
	        {
		        bool hasFuel = true;
		        int sumFuel = 0;
		        for (int j = 0; j < n; j++)
		        {
			        sumFuel += fuelLeft.Peek();

					// Here queue makes a full circle and doesn't just Dequeue
					// because we might need it again if this
					// isn't the right answer.
					fuelLeft.Enqueue(fuelLeft.Dequeue());

			        if (sumFuel < 0)
				        hasFuel = false;
		        }

		        if (hasFuel)
		        {
					Console.WriteLine(i);
					return;
		        }

				// Roll queue so we can test next rotation.
				fuelLeft.Enqueue(fuelLeft.Dequeue());
	        }

	        Console.WriteLine("Not possible.");
        }
    }
}