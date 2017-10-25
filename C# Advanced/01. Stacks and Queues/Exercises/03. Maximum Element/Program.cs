using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
	        int n = int.Parse(Console.ReadLine());
			Stack<int> numStack = new Stack<int>();
			Stack<int> maxNumStack = new Stack<int>();

	        for (int i = 0; i < n; i++)
	        {
				string[] inputTokens = Console.ReadLine()
					.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

		        string command = inputTokens[0];
		        switch (command)
		        {
					case "1":
						int num = int.Parse(inputTokens[1]);
						if (maxNumStack.Count == 0 || num >= maxNumStack.Peek())
							maxNumStack.Push(num); 
						numStack.Push(num);
						break;
					case "2":
						if (maxNumStack.Count > 0 && numStack.Pop() == maxNumStack.Peek())
							maxNumStack.Pop();
						break;
					case "3":
						if (maxNumStack.Count > 0)
							Console.WriteLine(maxNumStack.Peek());
						else
							Console.WriteLine(0);
						break;
		        }
	        }
        }
    }
}