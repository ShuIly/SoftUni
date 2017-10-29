using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine().ToLower();
			string word = Console.ReadLine().ToLower();
			int count = 0;
			int lastIndex = -1;
			while ((lastIndex = text.IndexOf(word, lastIndex + 1)) != -1)
			{
				count++;
			}

			Console.WriteLine(count);
		}
	}
}
