using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiply_an_Array_of_Doubles
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] stringNum = Console.ReadLine().Split(' ');
			double multiplier = double.Parse(Console.ReadLine());
			double[] num = new double[stringNum.Length];

			for (int i = 0; i < stringNum.Length; i++)
			{
				num[i] = double.Parse(stringNum[i]);
				Console.Write(num[i] * multiplier + " ");
			}
			Console.WriteLine();
		}
	}
}
