using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] arr = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(arr.Reverse());

	        while (stack.Count > 1)
	        {
		        int num1 = int.Parse(stack.Pop());
		        char op = char.Parse(stack.Pop());
		        int num2 = int.Parse(stack.Pop());

		        switch (op)
		        {
					case '+':
						// That's genius!
						stack.Push((num1 + num2).ToString());
						break;
					case '-':
						stack.Push((num1 - num2).ToString());
						break;
		        }
	        }

	        Console.WriteLine(stack.Pop());
        }
    }
}