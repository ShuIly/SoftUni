using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine();
			int nights = int.Parse(Console.ReadLine());

			double studioPrice = 0;
			double doublePrice = 0;
			double suitePrice = 0;

			int studioDiscount = 0;
			int doubleDiscount = 0;
			int suiteDiscount = 0;

			if (nights > 7)
			{
				if (month == "May" || month == "October")
				{
					studioDiscount = 5;
				}
				if (month == "September")
				{
					studioPrice -= 60;
				}
				if (month == "October")
				{
					studioPrice -= 50;
				}
			}
			if (nights > 14)
			{
				if (month == "June" || month == "September")
				{
					doubleDiscount = 10;
				}
				if (month == "July" || month == "August" || month == "December")
				{
					suiteDiscount = 15;
				}
			}

			if (month == "May" || month == "October")
			{
				studioPrice += 50 * nights;
				doublePrice += 65 * nights;
				suitePrice += 75 * nights;
			}
			if (month == "June" || month == "September")
			{
				studioPrice += 60 * nights;
				doublePrice += 72 * nights;
				suitePrice += 82 * nights;
			}
			if (month == "July" || month == "August" || month == "December")
			{
				studioPrice += 68 * nights;
				doublePrice += 77 * nights;
				suitePrice += 89 * nights;
			}

			studioPrice -= studioPrice * studioDiscount / 100;
			doublePrice -= doublePrice * doubleDiscount / 100;
			suitePrice -= suitePrice * suiteDiscount / 100;

			Console.WriteLine(
				$"Studio: {studioPrice:f2} lv.\n" +
				$"Double: {doublePrice:f2} lv.\n" +
				$"Suite: {suitePrice:f2} lv.\n"
				);
		}
	}
}
