using System;
using System.Collections.Generic;
using System.Numerics;

namespace _04.Convert_from_base_10_to_base_N
{
	class Program
	{
		static BigInteger GetBaseN(BigInteger num, int n)
		{
			BigInteger result = 0;
			BigInteger multiplier = 1;

			while (num > 0)
			{
				result += num % n * multiplier;
				num /= n;
				multiplier *= 10;
			}

			return result;
		}
		static void Main(string[] args)
		{
			string[] inputArgs = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			int b = int.Parse(inputArgs[0]);
			BigInteger num = BigInteger.Parse(inputArgs[1]);

			Console.WriteLine(GetBaseN(num, b));
		}
	}
}