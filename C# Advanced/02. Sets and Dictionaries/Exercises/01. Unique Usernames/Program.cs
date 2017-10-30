using System;
using System.Collections.Generic;

namespace _01.Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
	        var usernames = new HashSet<string>();
	        int n = int.Parse(Console.ReadLine());

	        for (int i = 0; i < n; i++)
	        {
		        usernames.Add(Console.ReadLine());
	        }

	        Console.WriteLine(string.Join(Environment.NewLine, usernames));
        }
    }
}