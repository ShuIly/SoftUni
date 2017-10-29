using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.String_Decryption
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] skipTake = Console.ReadLine().Split().Select(int.Parse).ToArray();
			char[] letters = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.Where(x => x >= 65 && x <= 90)
				.Skip(skipTake[0])
				.Take(skipTake[1])
				.Select(x => (char) x)
				.ToArray();

			Console.WriteLine(string.Join("", letters));
		}
	}
}
