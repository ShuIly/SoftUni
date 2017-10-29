using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.Big_Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			BigInteger num = 1;
			int factorial = int.Parse(Console.ReadLine());
			for (int i = 1; i <= factorial; i++)
			{
				num *= i;
			}
			Console.WriteLine(num);
		}
	}
}
