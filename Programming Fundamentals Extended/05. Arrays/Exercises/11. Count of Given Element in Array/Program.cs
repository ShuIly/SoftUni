using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Count_of_Given_Element_in_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] stringNum = Console.ReadLine().Split();
			int searchedNum = int.Parse(Console.ReadLine());
			int[] num = new int[stringNum.Length];
			int numFound = 0;

			for (int i = 0; i < stringNum.Length; i++)
			{
				num[i] = int.Parse(stringNum[i]);
				if (num[i] == searchedNum)
				{
					numFound++;
				}
			}
			Console.WriteLine(numFound);
		}
	}
}
