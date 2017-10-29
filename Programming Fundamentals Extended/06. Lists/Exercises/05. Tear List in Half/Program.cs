using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tear_List_in_Half
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int lengthMiddle = arr.Length / 2;
			int arrLength = arr.Length;

			// take only right half of the array
			int[] rightSide = arr.Skip(lengthMiddle).ToArray();
			List<int> changedList = new List<int>();

			for (int i = 0; i < lengthMiddle; i++)
			{
				changedList.Add(rightSide[i] / 10);
				changedList.Add(arr[i]);
				changedList.Add(rightSide[i] % 10);
			}

			Console.WriteLine(string.Join(" ", changedList));
		}
	}
}
