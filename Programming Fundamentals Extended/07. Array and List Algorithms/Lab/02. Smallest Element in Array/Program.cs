using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Smallest_Element_in_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int numCount = num.Length;
			int smallestNum = num[0];

			for (int i = 0; i < numCount; i++)
			{
				if (smallestNum > num[i])
				{
					smallestNum = num[i];
				}
			}

			Console.WriteLine(smallestNum);
		}
	}
}
