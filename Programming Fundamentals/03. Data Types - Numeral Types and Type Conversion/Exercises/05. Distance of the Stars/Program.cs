using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_the_Stars
{
	class Program
	{
		static void Main(string[] args)
		{
			long lightYearKm = 9450000000000;
			double earthToCentauri = 4.22 * lightYearKm;
			double earthToMilkyWay = 26000 * lightYearKm;
			double diameterMilkyWay = 100000 * lightYearKm;
			decimal observableUniverse = 46500000000m * lightYearKm;
			Console.WriteLine(earthToCentauri.ToString("e2"));
			Console.WriteLine(earthToMilkyWay.ToString("e2"));
			Console.WriteLine(diameterMilkyWay.ToString("e2"));
			Console.WriteLine(observableUniverse.ToString("e2"));
		}
	}
}
