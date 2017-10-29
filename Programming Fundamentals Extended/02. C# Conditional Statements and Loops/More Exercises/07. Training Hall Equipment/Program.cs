using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			int itemsToBuy = int.Parse(Console.ReadLine());

			double itemPriceSum = 0;

			for (int i = 0; i < itemsToBuy; i++)
			{
				string itemName = Console.ReadLine();
				double itemPrice = double.Parse(Console.ReadLine());

				int itemNumber = int.Parse(Console.ReadLine());
				if (itemNumber > 1)
				{
					itemName += "s";
				}

				itemPriceSum += itemPrice * itemNumber;

				Console.WriteLine($"Adding {itemNumber} {itemName} to cart.");
			}

			Console.WriteLine("Subtotal: ${0:F2}", itemPriceSum);

			if (itemPriceSum > budget)
			{
				Console.WriteLine("Not enough. We need ${0:F2} more.",	itemPriceSum - budget);
			}
			else
			{
				Console.WriteLine("Money left: ${0:F2}", budget - itemPriceSum);
			}
		}
	}
}
