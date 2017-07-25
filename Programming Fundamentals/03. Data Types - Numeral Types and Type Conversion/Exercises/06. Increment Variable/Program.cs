using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int overflow = 0;
			byte num = 0;
			for (int i = 0; i < n; i++)
			{
				num++;
				if (num == 0)
				{
					overflow++;
				}
			}
			Console.WriteLine(num);
			if (overflow > 0)
			{
				Console.WriteLine("Overflowed {0} times", overflow);
			}
		}
	}
}
