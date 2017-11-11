using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.String_Matrix_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
			int rotateGrad = Console.ReadLine()
				.Split(new []{ "Rotate(", ")" }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.First();
			rotateGrad %= 360;
			List<List<char>> charList = new List<List<char>>();

	        int maxLength = 0;
	        while (true)
	        {
		        string input = Console.ReadLine();
				if (input == "END")
					break;

		        if (maxLength < input.Length)
			        maxLength = input.Length;

				charList.Add(new List<char>());
		        foreach (char c in input)
					charList[charList.Count].Add(c);
	        }

	        switch (rotateGrad)
	        {
				case 90:
					for (int i = charList.Count - 1; i >= 0; i--)
					{
						for (int j = 0; j < UPPER; j++)
						{
							
						}
					}
	        }
        }
    }
}