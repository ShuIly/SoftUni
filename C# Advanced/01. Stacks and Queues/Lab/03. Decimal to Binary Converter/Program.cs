using System;
using System.Collections.Generic;
using System.Dynamic;

namespace _03.Decimal_to_Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
	        int decNum = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();

	        if (decNum == 0)
	        {
				Console.WriteLine(0);
				return;
	        }

	        while (decNum > 0)
	        {
		        stack.Push(decNum % 2);
				decNum /= 2;
	        }

	        string answer = "";
	        while (stack.Count != 0)
		        answer += stack.Pop();

	        Console.WriteLine(answer);
        }
    }
}