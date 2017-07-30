using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Union_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				List<int> additions = Console.ReadLine().Split().Select(int.Parse).ToList();
				int additionsCount = additions.Count;
				for (int j = 0; j < additionsCount; j++)
				{
					int currAddition = additions[j];
					if (list.Contains(currAddition))
					{
						list.RemoveAll(a => a == currAddition);
					}
					else
					{
						list.Add(currAddition);
					}
				}
			}

			list.Sort();

			Console.WriteLine(string.Join(" ", list));
		}
	}
}
