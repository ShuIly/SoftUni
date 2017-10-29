using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] capacity = Console.ReadLine().Split().Select(double.Parse).ToArray();
			double[] hourlyDischarge = Console.ReadLine().Split().Select(double.Parse).ToArray();
			int testingHours = int.Parse(Console.ReadLine());

			int capacityCount = capacity.Length;

			for (int i = 0; i < capacityCount; i++)
			{
				double capacityLeft = capacity[i] - hourlyDischarge[i] *  testingHours;
				if (capacityLeft > 0)
				{
					double percentage = capacityLeft / capacity[i] * 100;
					Console.WriteLine("Battery {0}: {1:F2} mAh ({2:F2})%", 
						i + 1, capacityLeft, Math.Round(percentage, 2));
				}
				else
				{
					int hoursLasted = (int) Math.Ceiling(capacity[i] / hourlyDischarge[i]);
					Console.WriteLine("Battery {0}: dead (lasted {1} hours)", i + 1, hoursLasted);
				}
			}
		}
	}
}
