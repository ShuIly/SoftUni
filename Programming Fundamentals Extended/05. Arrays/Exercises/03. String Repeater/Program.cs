using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Repeater
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = Console.ReadLine();
			int n = int.Parse(Console.ReadLine());
			string repeatedString = repeatString(str, n);

			Console.WriteLine(repeatedString);
		}
		static string repeatString(string str, int n)
		{
			string endString = "";
			for (int i = 0; i < n; i++)
			{
				endString += str;
			}
			return endString;
		}
	}
}
