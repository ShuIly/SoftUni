using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
			Stack<string> text = new Stack<string>();
	        int n = int.Parse(Console.ReadLine());

	        for (int i = 0; i < n; i++)
	        {
		        string[] inputTokens = Console.ReadLine()
					.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
		        string command = inputTokens[0];

		        switch (command)
		        {
					case "1":
						if (text.Count == 0)
							text.Push(inputTokens[1]);
						else
							text.Push(text.Peek() + inputTokens[1]);
						break;
					case "2":
						int count = int.Parse(inputTokens[1]);

						// Push a new string with length of
						// Peek().Length - count
						text.Push(new string(text.Peek()
							.Take(text.Peek().Length - count)
							.ToArray()));
						break;
					case "3":
						int index = int.Parse(inputTokens[1]);
						Console.WriteLine(text.Peek()[index - 1]);
						break;
					case "4":
						text.Pop();
						break;
		        }
	        }
        }
    }
}