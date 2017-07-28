using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Integer_to_Base
{
	class Program
	{
		static void Main(string[] args)
		{
			long num = long.Parse(Console.ReadLine());
			int toBase = int.Parse(Console.ReadLine());
			Console.WriteLine(convertToBase(num, toBase));
		}

		static string convertToBase(long num, int toBase)
		{
			// note that this algorithm works only for base 2 to 10.
			// from base 11 upwards you have to implement letters too
			string result = "";
			while (num > 0)
			{
				int remainder = (int) (num % toBase);
				// because remainders have to be read from bottom up
				// we place remainder at front
				result = remainder.ToString() + result;
				num /= toBase;
			}
			return result;
		}
	}
}
