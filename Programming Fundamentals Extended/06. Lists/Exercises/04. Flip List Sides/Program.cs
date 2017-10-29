using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();
			int numToCenter = num.Count / 2;
			int numLength = num.Count - 1;

			for (int i = 1; i < numToCenter; i++)
			{
				int temp = num[i];
				num[i] = num[numLength - i];
				num[numLength - i] = temp;
			}

			Console.WriteLine(string.Join(" ", num));
		}
	}
}
