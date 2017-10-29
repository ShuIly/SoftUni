using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
	class Program
	{
		static void Main(string[] args)
		{
			int numPeople = int.Parse(Console.ReadLine());
			string package = Console.ReadLine();

			double price = 0;

			int discount = 0;
			
			switch (package)
			{
				case "Normal":
					price += 500;
					discount = 5;
					break;
				case "Gold":
					price += 750;
					discount = 10;
					break;
				case "Platinum":
					price += 1000;
					discount = 15;
					break;
			}

			if (numPeople <= 120 && numPeople > 100)
			{
				price += 7500;
				price -= price * discount / 100;
				Console.WriteLine("We can offer you the Great Hall");
				Console.WriteLine("The price per person is {0:f2}$", price / numPeople);
			}
			else if (numPeople > 50 && numPeople <= 100)
			{
				price += 5000;
				price -= price * discount / 100;
				Console.WriteLine("We can offer you the Terrace");
				Console.WriteLine("The price per person is {0:f2}$", price / numPeople);
			}
			else if (numPeople > 0 && numPeople <= 50)
			{
				price += 2500;
				price -= price * discount / 100;
				Console.WriteLine("We can offer you the Small Hall");
				Console.WriteLine("The price per person is {0:f2}$", price / numPeople);
			}
			else
			{
				Console.WriteLine("We do not have an appropriate hall.");
			}
		}
	}
}
