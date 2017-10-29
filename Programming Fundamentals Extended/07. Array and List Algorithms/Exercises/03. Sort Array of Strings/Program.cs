using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();
			int wordsCount = words.Length;

			for (int i = 0; i < wordsCount; i++)
			{
				for (int j = i; j > 0; j--)
				{
					if (words[j].CompareTo(words[j - 1]) < 0)
					{
						Swap(ref words[j], ref words[j - 1]);
					}
				}
			}

			Console.WriteLine(string.Join(" ", words));
		}

		static void Swap(ref string word1, ref string word2)
		{
			string temp = word1;
			word1 = word2;
			word2 = temp;
		}
	}
}
