using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _01.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
			string input = Console.ReadLine();
			Stack<char> stack = new Stack<char>();

	        foreach (char c in input)
	        {
		        stack.Push(c);
	        }

	        string reversedInput = "";
	        while (stack.Count > 0)
	        {
		        reversedInput += stack.Pop();
	        }

	        Console.WriteLine(reversedInput);
        }
    }
}