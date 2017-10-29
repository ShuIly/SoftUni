using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distinct_List
{
	class Program
	{
		static void Main(string[] args)
		{
			// Distinct() ensures that there are no duplicate numbers, or strings, or whatever.
			List<int> list = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();
			Console.WriteLine(string.Join(" ", list));
		}
	}
}
