using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
	class Program
	{
		static void Main(string[] args)
		{
			int height = int.Parse(Console.ReadLine());

			// TOP TO MIDDLE
			for (int i = height - 2, j = 0; i > 0; i -= 2, j++)
			{
				Console.WriteLine("{0}x{1}x", new string(' ', j), new string(' ', i));
			}

			// MIDDLE
			Console.WriteLine("{0}x", new string(' ', (height - 1) / 2));

			// MIDDLE TO BOTTOM
			for (int i = 1, j = (height - 3) / 2; i <= height - 2; i += 2, j--)
			{
				Console.WriteLine("{0}x{1}x", new string(' ', j), new string(' ', i));
			}
		}
	}
}
