using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Different_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int min = int.Parse(Console.ReadLine());
			int max = int.Parse(Console.ReadLine());

			if (max - min >= 4)
			{
				for (int i = min; i <= max - 4; i++)
				{
					for (int j = i + 1; j <= max - 3; j++)
					{
						for (int k = j + 1; k <= max - 2; k++)
						{
							for (int l = k + 1; l <= max - 1; l++)
							{
								for (int m = l + 1; m <= max; m++)
								{
									Console.WriteLine($"{i} {j} {k} {l} {m}");
								}
							}
						}
					}
				}
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}
