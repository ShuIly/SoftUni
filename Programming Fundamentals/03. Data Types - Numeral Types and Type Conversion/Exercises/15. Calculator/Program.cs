using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			char op = char.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());

			switch (op)
			{
				case '+':
					Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
					break;
				case '-':
					Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
					break;
				case '*':
					Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
					break;
				case '/':
					Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
					break;
			}
		}
	}
}
