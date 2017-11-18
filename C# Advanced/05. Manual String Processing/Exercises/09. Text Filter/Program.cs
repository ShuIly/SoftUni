using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] words = Console.ReadLine()
				.Split(new []{ ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
			string str = Console.ReadLine();

			var wordIndices = new SortedDictionary<int, string>();
	        foreach (string word in words)
	        {
		        int index = -1;
		        while ((index = str.IndexOf(word, index + 1, StringComparison.Ordinal)) != -1)
		        {
					wordIndices.Add(index, word);
		        }
	        }

	        int currIndex = 0;
			StringBuilder result = new StringBuilder(str.Length);
	        foreach (var wordIndex in wordIndices)
	        {
		        for (int i = currIndex; i < wordIndex.Key; i++)
		        {
			        result.Append(str[i]);
		        }

		        for (int i = 0; i < wordIndex.Value.Length; i++)
		        {
					result.Append('*');
		        }

		        currIndex = wordIndex.Key + wordIndex.Value.Length;
	        }

	        for (int i = currIndex; i < str.Length; i++)
	        {
		        result.Append(str[i]);
	        }

	        Console.WriteLine(result);
        }
    }
}