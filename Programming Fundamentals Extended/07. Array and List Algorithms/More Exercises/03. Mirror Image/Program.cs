using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mirror_Image
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] num = Console.ReadLine().Split();
			string command = Console.ReadLine();

			while (command != "Print")
			{
				int n = int.Parse(command);
				for (int i = 0, j = n - 1; i <= j; i++, j--)
				{
					Swap(ref num[i], ref num[j]);
				}

				for (int i = n + 1, j = num.Length - 1; i <= j; i++, j--)
				{
					Swap(ref num[i], ref num[j]);
				}
				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", num));
		}

		static void Swap(ref string num1, ref string num2)
		{
			string temp = num1;
			num1 = num2;
			num2 = temp;
		}
	}
}
