using System;
using System.Collections.Generic;

namespace _11.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] words = Console.ReadLine()
				.Split(new []{ ' ', ',', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
			SortedSet<string> palindromes = new SortedSet<string>();

	        foreach (string word in words)
	        {
		        bool isPalindrome = true;
		        for (int i = 0, j = word.Length - 1; i <= j; i++, j--)
		        {
			        if (word[i] != word[j])
			        {
				        isPalindrome = false;
						break;
			        }
		        }

		        if (isPalindrome)
		        {
			        palindromes.Add(word);
		        }
	        }

	        Console.WriteLine($"[{string.Join(", ", palindromes)}]");
        }
    }
}