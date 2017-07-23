using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_Drink_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			string person = Console.ReadLine();
			int volume = int.Parse(Console.ReadLine());
			switch (person)
			{
				case "Athlete":
					Console.WriteLine("The {0} has to pay {1:f2}.", person, volume * 0.7);
					break;
				case "Businessman":
				case "Businesswoman":
					Console.WriteLine("The {0} has to pay {1:f2}.", person, volume * 1);
					break;
				case "SoftUni Student":
					Console.WriteLine("The {0} has to pay {1:f2}.", person, volume * 1.7);
					break;
				default:
					Console.WriteLine("The {0} has to pay {1:f2}.", person, volume * 1.2);
					break;
			}
		}
	}
}
