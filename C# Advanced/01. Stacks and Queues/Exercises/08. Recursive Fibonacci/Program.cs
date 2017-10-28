using System;
using System.Collections.Generic;

namespace _08.Recursive_Fibonacci
{
    class Program
    {
	    static long[] memorization;

	    static long GetFibonacci(int n)
	    {
		    if (n == 0 || n == 1)
			    return n;

		    if (memorization[n] != 0)
			    return memorization[n];

		    memorization[n] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
		    return memorization[n];
	    }

        static void Main(string[] args)
        {
	        int n = int.Parse(Console.ReadLine());
	        memorization = new long[n + 1];
	        Console.WriteLine(GetFibonacci(n));
        }
    }
}