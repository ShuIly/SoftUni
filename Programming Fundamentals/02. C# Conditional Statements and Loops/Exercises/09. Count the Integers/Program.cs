using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			int integerNum = 0;
			while (true)
			{
				try
				{
					int.Parse(Console.ReadLine());
					integerNum++;
				}
				catch
				{
					Console.WriteLine(integerNum);
					break;
				}
			}
		}
	}
}
