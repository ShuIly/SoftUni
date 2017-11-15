using System;
using System.Collections.Generic;
using System.Numerics;

namespace _05.Convert_from_base_N_to_base_10
{
    class Program
    {
		static BigInteger GetBase10(BigInteger num, int b)
		{
			Stack<char> digitStack = new Stack<char>(num.ToString().ToCharArray());
			BigInteger result = 0;
			int power = 0;

			while (digitStack.Count > 0)
			{
				result += BigInteger.Pow(b, power) * (BigInteger) Char.GetNumericValue(digitStack.Pop());
				power++;
			}

			return result;
		}
		static void Main(string[] args)
		{
			string[] inputArgs = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			int b = int.Parse(inputArgs[0]);
			BigInteger num = BigInteger.Parse(inputArgs[1]);

			Console.WriteLine(GetBase10(num, b));
		}
    }
}