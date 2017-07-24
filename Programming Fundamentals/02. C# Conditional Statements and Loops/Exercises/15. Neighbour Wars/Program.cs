using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
	class Program
	{
		static void Main(string[] args)
		{
			int peshoDmg = int.Parse(Console.ReadLine());
			int goshoDmg = int.Parse(Console.ReadLine());

			int peshoHp = 100;
			int goshoHp = 100;
			int round = 1;

			while (true)
			{
				if (round % 2 != 0)
				{
					goshoHp -= peshoDmg;
					if (goshoHp <= 0)
					{
						Console.WriteLine("Pesho won in {0}th round.", round);
						break;
					}
					Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHp);
				}
				else
				{
					peshoHp -= goshoDmg;
					if (peshoHp <= 0)
					{
						Console.WriteLine("Gosho won in {0}th round.", round);
						break;
					}
					Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHp);
				}
				
				if (round % 3 == 0)
				{
					goshoHp += 10;
					peshoHp += 10;
				}
				round++;
			}
		}
	}
}
