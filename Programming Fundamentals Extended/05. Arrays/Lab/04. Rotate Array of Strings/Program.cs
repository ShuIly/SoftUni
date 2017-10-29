using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();
			Console.Write(words[words.Length - 1] + " ");

			for (int i = 0; i < words.Length - 1; i++)
			{
				Console.Write(words[i] + " ");
			}
			Console.WriteLine();
		}
	}
}
