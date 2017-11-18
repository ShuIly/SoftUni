using System;
using System.Text;

namespace _10.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
			string str = Console.ReadLine();

			StringBuilder result = new StringBuilder();
	        foreach (char c in str)
	        {
		        result.AppendFormat("\\u{0:x4}", (int) c);
	        }

	        Console.WriteLine(result);
        }
    }
}