using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
			string parens = Console.ReadLine();
	        Stack<char> stack = new Stack<char>();

	        foreach (char c in parens)
	        {
			    if (c == '(' || c == '[' || c == '{')
					stack.Push(c);
			    else
			    {
				    if (stack.Count == 0)
				    {
					    Console.WriteLine("NO");
						return;
				    }

				    if (stack.Peek() == '(' && c == ')' ||
						stack.Peek() == '[' && c == ']' ||
						stack.Peek() == '{' && c == '}')
					    stack.Pop();
				    else
				    {
						Console.WriteLine("NO");
						return;
				    }
			    }
	        }

	        Console.WriteLine(stack.Count > 0 ? "NO" : "YES");
        }
    }
}