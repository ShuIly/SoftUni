using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal startingBalance = decimal.Parse(Console.ReadLine());

			decimal sumPrice = 0m;
			bool gameTime = false;

			while (!gameTime)
			{
				decimal gamePrice = 0m;
				string gameName = Console.ReadLine();

				switch (gameName.ToLower())
				{
					case "outfall 4":
						gamePrice = 39.99m;
						break;
					case "cs: og":
						gamePrice = 15.99m;
						break;
					case "zplinter zell":
						gamePrice = 19.99m;
						break;
					case "honored 2":
						gamePrice = 59.99m;
						break;
					case "roverwatch":
						gamePrice = 29.99m;
						break;
					case "roverwatch origins edition":
						gamePrice = 39.99m;
						break;
					case "game time":
						gameTime = true;
						continue;
					default:
						Console.WriteLine("Not Found");
						continue;
				}

				if (sumPrice + gamePrice > startingBalance)
				{
					Console.WriteLine("Too Expensive");
				}
				else
				{
					Console.WriteLine("Bought {0}", gameName);
					sumPrice += gamePrice;
				}
			}

			if (sumPrice < startingBalance)
			{
				Console.WriteLine("Total spent: ${0:F2}. Remaining: ${1:F2}", sumPrice, startingBalance - sumPrice);
			}
			else if (sumPrice == startingBalance)
			{
				Console.WriteLine("Out of money!");
			}
		}
	}
}
