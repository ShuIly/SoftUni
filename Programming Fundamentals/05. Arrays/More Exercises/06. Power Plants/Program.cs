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

			decimal getBlooms = (decimal) (bestPlantLife + numPlants - bestPlantIndex) / numPlants;
			decimal sumBlooms = 0;
			int seasons = 0;


			int daysLasted = (int) sumBlooms + bestPlantLife;

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
