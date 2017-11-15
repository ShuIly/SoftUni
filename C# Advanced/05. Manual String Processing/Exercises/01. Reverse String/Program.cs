using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
			// We're not using a string because that will give us a Memory Limit when
			// reversing the string with LINQ.
			char[] str = Console.ReadLine().ToCharArray();
			Array.Reverse(str);
	        Console.WriteLine(str);
        }
    }
}