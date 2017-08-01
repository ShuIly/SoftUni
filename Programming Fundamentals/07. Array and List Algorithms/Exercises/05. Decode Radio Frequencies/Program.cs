using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal[] num = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
			List<char> result = new List<char>();

			int numCount = num.Length;

			for (int i = 0; i < numCount; i++)
			{
				int[] parts = num[i].ToString().Split('.').Select(int.Parse).ToArray();

				char leftChar = (char)parts[0];
				char rightChar = (char)parts[1];

				if (parts[1] > 0)
				{
					result.Insert(result.Count - i, rightChar);
				}
				if (parts[0] > 0)
				{
					result.Insert(i, leftChar);
				}
			}

			Console.WriteLine(string.Join("", result));
		}
	}
}
