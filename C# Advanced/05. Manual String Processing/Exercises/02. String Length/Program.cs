using System;
using System.Linq;

namespace _02.String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
			string str = new string(Console.ReadLine().Take(20).ToArray());
	        Console.WriteLine($"{str.PadRight(20, '*')}");
        }
    }
}