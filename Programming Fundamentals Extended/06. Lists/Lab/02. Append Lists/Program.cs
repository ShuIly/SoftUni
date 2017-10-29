using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] splitByI = Console.ReadLine().Split('|');

			for (int i = splitByI.Length - 1; i >= 0; i--)
			{
				List<int> num = splitByI[i].Split(new char[] { ' ' }, 
					StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

				Console.Write(string.Join(" ", num) + " ");
			}

			Console.WriteLine();
		}
	}
}
