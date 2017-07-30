using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
			string insertNum = Console.ReadLine();

			while (insertNum != "end")
			{
				int insertIndex = (int) Char.GetNumericValue(insertNum[0]);
				list.Insert(insertIndex, int.Parse(insertNum));

				insertNum = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", list));
		}
	}
}
