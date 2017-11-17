using System;

namespace _06.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
			string str = Console.ReadLine();
			string word = Console.ReadLine();

	        int count = 0;
	        int index = -1;
	        while ((index = str.IndexOf(word, index + 1, StringComparison.CurrentCultureIgnoreCase)) != -1)
	        {
		        count++;
	        }

	        Console.WriteLine(count);
        }
    }
}