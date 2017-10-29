using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traveling_Light_Speed
{
	class Program
	{
		static void Main(string[] args)
		{
			long lightYear = 9450000000000;
			int lightSpeed = 300000;

			decimal n = decimal.Parse(Console.ReadLine());

			long seconds = (long) (n * lightYear / lightSpeed);
			long minutes = seconds / 60;
			seconds %= 60;
			long hours = minutes / 60;
			minutes %= 60;
			long days = hours / 24;
			hours %= 24;
			long weeks = days / 7;
			days %= 7;

			Console.WriteLine("{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds",
				weeks, days, hours, minutes, seconds);
		}
	}
}
