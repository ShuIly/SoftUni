using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_by_Odds
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = Math.Abs(int.Parse(Console.ReadLine()));
			int sumOddDigits = FindSumOddDigits(num);
			int sumEvenDigits = FindSumEvenDigits(num);
			int result = sumEvenDigits * sumOddDigits;

			Console.WriteLine(result);
		}
		static int FindSumOddDigits(int num)
		{
			int result = 0;
			while (num > 0)
			{
				int lastDigit = num % 10;
				if (lastDigit % 2 != 0)
				{
					result += lastDigit;
				}
				num /= 10;
			}
			return result;
		}
		static int FindSumEvenDigits(int num)
		{
			int result = 0;
			while (num > 0)
			{
				int lastDigit = num % 10;
				if (lastDigit % 2 == 0)
				{
					result += lastDigit;
				}
				num /= 10;
			}
			return result;
		}
	}
}
