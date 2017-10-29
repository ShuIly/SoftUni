using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string delimiter = Console.ReadLine();
			int n = int.Parse(Console.ReadLine());

			string finalString = "";
			for (int i = 0; i < n - 1; i++)
			{
				finalString += Console.ReadLine() + delimiter;
			}
			finalString += Console.ReadLine();

			Console.WriteLine(finalString);
		}
	}
}
