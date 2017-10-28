using System;
using System.Collections.Generic;

namespace _09.Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
			Stack<long> fibonacci = new Stack<long>(new long[]{ 1, 1 });
	        int n = int.Parse(Console.ReadLine());

	        for (int i = 2; i < n; i++)
	        {
		        long frontFibonacci = fibonacci.Pop();
		        long lastFibonacci = fibonacci.Pop();
				fibonacci.Push(frontFibonacci);
				fibonacci.Push(lastFibonacci + frontFibonacci);
	        }

	        Console.WriteLine(n == 0 ? 0 : fibonacci.Peek());
        }
    }
}