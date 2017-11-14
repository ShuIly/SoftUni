using System;
using System.Text;

namespace _05.Concatenate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
	        int n = int.Parse(Console.ReadLine());
			StringBuilder sb = new StringBuilder();

	        for (int i = 0; i < n; i++)
	        {
		        sb.Append(Console.ReadLine() + " ");
	        }

	        Console.WriteLine(sb);
        }
    }
}