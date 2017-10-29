using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_Occurences_of_Larger_Num_in_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] stringNum = Console.ReadLine().Split();
			double chosenNum = double.Parse(Console.ReadLine());
			double[] num = new double[stringNum.Length];
			double biggerNum = 0;

			for (int i = 0; i < stringNum.Length; i++)
			{
				num[i] = double.Parse(stringNum[i]);
				if (num[i] > chosenNum)
				{
					biggerNum++;
				}
			}
			Console.WriteLine(biggerNum);
		}
	}
}
