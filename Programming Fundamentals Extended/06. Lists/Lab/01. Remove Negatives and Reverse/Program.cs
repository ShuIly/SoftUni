using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();

			num.RemoveAll(a => a < 0);
			num.Reverse();

			if (num.Any())
			{
				Console.WriteLine(string.Join(" ", num));
			}
			else
			{
				Console.WriteLine("empty");
			}
		}
	}
}
