using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> num = Console.ReadLine().Split().Select(double.Parse).ToList();
			List<int> squareNum = new List<int>();

			for (int i = 0; i < num.Count; i++)
			{
				if (Math.Sqrt(num[i]) == (int) Math.Sqrt(num[i]))
				{
					squareNum.Add((int) num[i]);
				}
			}

			// sort in descending order
			squareNum.Sort((a, b) => b.CompareTo(a));

			Console.WriteLine(string.Join(" ", squareNum));
		}
	}
}
