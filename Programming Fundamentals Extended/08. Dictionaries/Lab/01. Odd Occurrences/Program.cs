using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Occurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().ToLower().Split();
			Dictionary<string, int> wordCount = new Dictionary<string, int>();
			int numWords = words.Length;

			for (int i = 0; i < numWords; i++)
			{
				string currWord = words[i];
				if (!wordCount.ContainsKey(currWord))
				{
					wordCount.Add(currWord, 1);
				}
				else
				{
					wordCount[currWord]++;
				}
			}

			List<string> oddWords = new List<string>();

			foreach (KeyValuePair<string, int> word in wordCount)
			{
				if (word.Value % 2 != 0)
				{
					oddWords.Add(word.Key);
				}
			}

			Console.WriteLine(string.Join(", ", oddWords));
		}
	}
}
