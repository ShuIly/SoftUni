using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
	class Program
	{
		static void Main(string[] args)
		{
			string num = Console.ReadLine();
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine(getNthDigit(num, n));
		}
		static char getNthDigit(string num, int n)
		{
			return num[num.Length - n];
		}
	}
}
