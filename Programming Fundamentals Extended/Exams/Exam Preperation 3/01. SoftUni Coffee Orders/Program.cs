using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.SoftUni_Coffee_Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			decimal totalPrice = 0;
			StringBuilder result = new StringBuilder(); 

			for (int i = 0; i < n; i++)
			{
				decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
				string orderDateString = Console.ReadLine();
				DateTime orderDate = DateTime.ParseExact(orderDateString, @"d/M/yyyy", CultureInfo.InvariantCulture);
				int capsulesCount = int.Parse(Console.ReadLine());

				int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

				decimal orderPrice = pricePerCapsule * daysInMonth * capsulesCount;

				totalPrice += orderPrice;

				result.Append($"The price for the coffee is: ${Math.Round(orderPrice, 2):F2}\n");
			}

			result.Append($"Total: ${totalPrice:F2}");
			Console.WriteLine(result);
		}
	}
}