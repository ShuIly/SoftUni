using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<decimal> num = Console.ReadLine().Split().Select(decimal.Parse).ToList();

			// -1 because if "i" is the last element "i + 1" will throw OutOfRange exception.
			for (int i = 0; i < num.Count - 1; i++)
			{
				if (num[i] == num[i + 1])
				{
					num[i + 1] *= 2;
					num.RemoveAt(i);
					
					// -1 because it gets immediately incremented to 0
					i = -1; 
				}
			}

			Console.WriteLine(string.Join(" ", num));
		}
	}
}
