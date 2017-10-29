using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			Console.WriteLine(GetMin(GetMin(a, b), c));
		}
		static int GetMin(int a, int b)
		{
			if (a > b)
			{
				return b;
			}
			else
			{
				return a;
			}
		}
	}
}
