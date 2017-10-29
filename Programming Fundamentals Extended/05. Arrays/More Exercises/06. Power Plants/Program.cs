using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Power_Plants
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] plant = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int numPlants = plant.Length;
			int bestPlantIndex = -1;
			int bestPlantLife = -1;

			for (int i = 0; i < numPlants; i++)
			{
				if (bestPlantLife < plant[i])
				{
					bestPlantLife = plant[i];
					bestPlantIndex = i;
				}
			}

			int daysLasted = 0;
			int seasons = 0;
			int bloomPeriod = 0;
			int seasonPeriod = 0;
			int blooms = 0;
			
			while (bestPlantLife > 0)
			{
				if (bloomPeriod == bestPlantIndex)
				{
					bestPlantLife++;
					blooms++;
				}

				// plant has to be alive to bloom in season
				if (seasonPeriod == numPlants - 1 && bestPlantLife > 1)
				{
					bestPlantLife++;
					seasons++;
					// -1 because it gets incremented immediately after
					seasonPeriod = -1; 
				}

				if (bloomPeriod == numPlants - 1) 
				{
					bloomPeriod = -1;
				}

				daysLasted++;
				bloomPeriod++;
				seasonPeriod++;
				bestPlantLife--;
			}

			if (seasons == 1)
			{
				Console.WriteLine("survived {0} days ({1} season)", daysLasted, seasons);
			}
			else
			{
				Console.WriteLine("survived {0} days ({1} seasons)", daysLasted, seasons);
			}
		}
	}
}
