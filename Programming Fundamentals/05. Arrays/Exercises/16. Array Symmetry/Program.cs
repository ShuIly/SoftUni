using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Array_Symmetry
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();
			Console.WriteLine(IsSymmetric(words));
		}
		static string IsSymmetric(string[] words)
		{
			for (int i = 0, j = words.Length - 1; i < words.Length; i++, j--)
			{
				if (words[i] != words[j])
				{
					return "No";
				}
			}
			return "Yes";
		}
	}
}
