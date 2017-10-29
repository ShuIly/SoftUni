using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
			Dictionary<int, int> count = new Dictionary<int, int>();

			for (int i = 0; i < num.Length; i++)
			{
				// if it doesn't exist add it to dictionary.
				if (!count.ContainsKey(num[i]))
				{
					count.Add(num[i], 1);
				}
				else
				{
					// if it exist increment count for current number.
					count[num[i]]++;
				}
			}

			// create sorted list of single numbers that were repeating.
			// for example "1 1 1 2 2 3 3 3" becomes "1 2 3".
			List<int> sortedNum = count.Keys.ToList();
			sortedNum.Sort();

			for (int i = 0; i < sortedNum.Count; i++)
			{
				// print numbers and their count in ascending order.
				Console.WriteLine("{0} -> {1}", sortedNum[i], count[sortedNum[i]]);
			}
		}
	}
}
