using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Reverse_Numbers_with_Stack
{
	class Program
    {
        static void Main(string[] args)
        {
	        Stack<int> numStack = new Stack<int>
				(Console.ReadLine()
				.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse));

	        string answer = "";
	        while (numStack.Count > 0)
		        answer += numStack.Pop() + " ";

	        Console.WriteLine(answer);
        }
    }
}