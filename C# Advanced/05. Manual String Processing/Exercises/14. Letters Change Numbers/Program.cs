using System;

namespace _14.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] words = Console.ReadLine()
				.Split(new []{ ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

	        decimal sum = 0;
	        foreach (var word in words)
	        {
		        decimal num = decimal.Parse(word.Substring(1, word.Length - 2));
		        int firstLetterPositionInAlphabet = Char.ToLower(word[0]) - 'a' + 1;
		        char firstLetter = word[0];

		        if (Char.IsLower(firstLetter))
		        {
			        num *= firstLetterPositionInAlphabet;
		        }
		        else
		        {
			        num /= firstLetterPositionInAlphabet;
		        }

		        int secondLetterPositionInAlphabet = Char.ToLower(word[word.Length - 1]) - 'a' + 1;
		        char secondLetter = word[word.Length - 1];

		        if (Char.IsLower(secondLetter))
		        {
			        num += secondLetterPositionInAlphabet;
		        }
		        else
		        {
			        num -= secondLetterPositionInAlphabet;
		        }

		        sum += num;
	        }

	        Console.WriteLine($"{sum:F2}");
        }
    }
}