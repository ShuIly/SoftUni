using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();
			Dictionary<string, int> wordCount = new Dictionary<string, int>();

			int wordsCount = words.Length;

			for (int i = 0; i < wordsCount; i++)
			{
				if (wordCount.ContainsKey(words[i]))
				{
					wordCount[words[i]]++;
				}
				else
				{
					wordCount.Add(words[i], 1);
				}
			}

			foreach (KeyValuePair<string, int> item in wordCount.OrderByDescending(i => i.Value))
			{
				string word = item.Key;
				int count = item.Value;
				decimal percent = (decimal) count / wordsCount * 100;
				Console.WriteLine("{0} -> {1} times ({2:F2}%)", word, count, percent);
			}

		}
	}
}
