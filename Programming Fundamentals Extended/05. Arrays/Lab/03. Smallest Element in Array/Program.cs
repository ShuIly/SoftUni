using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Smallest_Element_in_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] stringNum = Console.ReadLine().Split();
			int[] num = new int[stringNum.Length];
			int smallestNum = int.MaxValue;

			for (int i = 0; i < stringNum.Length; i++)
			{
				num[i] = int.Parse(stringNum[i]);
				if (smallestNum > num[i])
				{
					smallestNum = num[i];
				}
			}
			Console.WriteLine(smallestNum);
		}
	}
}
