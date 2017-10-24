using System;
using System.Collections.Generic;

namespace _04.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
			string input = Console.ReadLine();
			Stack<int> indexStack = new Stack<int>();
	        for (int i = 0; i < input.Length; i++)
	        {
		        if (input[i] == '(')
		        {
			        indexStack.Push(i);
		        }
				else if (input[i] == ')')
		        {
			        int startIndex = indexStack.Pop();
			        int length = i - startIndex + 1;
			        Console.WriteLine(input.Substring(startIndex, length));
		        }
	        }
        }
    }
}