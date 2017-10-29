using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				int num = i;
				int sumDigits = 0;
				while (num > 0)
				{
					sumDigits += num % 10;
					num /= 10;
				}
				bool isSpecial = sumDigits == 5 || sumDigits == 7 || sumDigits == 11;
				Console.WriteLine("{0} -> {1}", i, isSpecial);
			}
		}
	}
}
