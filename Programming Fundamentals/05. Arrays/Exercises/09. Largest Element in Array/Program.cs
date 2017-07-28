using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Largest_Element_in_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] num = new int[n];

			num[0] = int.Parse(Console.ReadLine());
			int maxNum = num[0];

			for (int i = 1; i < n; i++)
			{
				num[i] = int.Parse(Console.ReadLine());
				if (num[i] > maxNum)
				{
					maxNum = num[i];
				}
			}
			Console.WriteLine(maxNum);
		}
	}
}
