using System;

namespace _12.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] inputArgs = Console.ReadLine()
				.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries);

	        string str1 = inputArgs[0];
	        string str2 = inputArgs[1];

	        int sum = 0;

	        int minLength = Math.Min(str2.Length, str1.Length);
	        for (int i = 0; i < minLength; i++)
	        {
		        sum += str1[i] * str2[i];
	        }

	        for (int i = minLength; i < str1.Length; i++)
	        {
		        sum += str1[i];
	        }

	        for (int i = minLength; i < str2.Length; i++)
	        {
		        sum += str2[i];
	        }

	        Console.WriteLine(sum);
        }
    }
}