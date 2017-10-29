using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Data
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();
			string command = Console.ReadLine();

			num = num.Where(x => x >= num.Average()).ToList();

			if (command == "Min")
			{
				Console.WriteLine(num.Min());
			}
			else if (command == "Max")
			{
				Console.WriteLine(num.Max());
			}
			else if (command == "All")
			{
				Console.WriteLine(string.Join(" ", num.OrderBy(x => x)));
			}
		}
	}
}
