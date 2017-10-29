using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Holidays_Between_Two_Dates
{
	class Program
	{
		static void Main()
		{
			// dd.mm.yyyy 1) "m" is minutes, not months. 2) we need only 1 d and M, because otherwise
			// we have to always add zeroes in front (for example 03.05.2015, not 3.5.2015)
			var startDate = DateTime.ParseExact(Console.ReadLine(),
				"d.M.yyyy", CultureInfo.InvariantCulture); 
			var endDate = DateTime.ParseExact(Console.ReadLine(),
				"d.M.yyyy", CultureInfo.InvariantCulture);
			var holidaysCount = 0;

			// dates are strings so they are immutable (date.AddDays(1) => date = date.AddDays(1))
			for (var date = startDate; date <= endDate; date = date.AddDays(1)) 
				// here we just change && to || (because day.DayOfWeek can't be Sat and Sun at the same time)
				if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
					holidaysCount++;
			Console.WriteLine(holidaysCount);
		}

	}
}
