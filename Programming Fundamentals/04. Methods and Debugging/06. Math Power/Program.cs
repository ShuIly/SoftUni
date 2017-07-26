using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
	class Program
	{
		static void Main(string[] args)
		{
			double num = double.Parse(Console.ReadLine());
			int pow = int.Parse(Console.ReadLine());
			double result = RaiseToPower(num, pow);

			Console.WriteLine(result);
		}
		static double RaiseToPower(double num, int pow)
		{
			double result = 1;
			for (int i = 0; i < pow; i++)
			{
				result *= num;
			}
			return result;
		}
	}
}
