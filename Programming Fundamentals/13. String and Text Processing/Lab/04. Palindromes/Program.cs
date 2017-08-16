using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] text = Console.ReadLine()
				.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
			HashSet<string> palindromes = new HashSet<string>();
			foreach (var word in text)
			{
				/*
				for (int i = 0, j = word.Length - 1; i <= j; i++, j--)
				{
					if (word[i] != word[j])
					{
						isPalindrome = false;
						break;
					}

					if (isPalindrome)
					{
						palindromes.Add(word);
					}
				}
				*/

				if (word.SequenceEqual(word.Reverse()))
				{
					palindromes.Add(word);
				}
			}
			Console.WriteLine(string.Join(", ", palindromes.OrderBy(p => p)));
		}
	}
}
