using System;
using System.Linq;

namespace _03.Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] nums = Console.ReadLine()
				.Split(new []{ ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

	        int num1 = int.Parse(nums[0]);
	        double num2 = double.Parse(new string(nums[1].Take(10).ToArray()));
	        double num3 = double.Parse(new string(nums[2].Take(10).ToArray()));

	        string hex = new string(num1.ToString("X").Take(10).ToArray());
			string binary = new string(Convert.ToString(num1, 2).Take(10).ToArray());

	        Console.WriteLine($"|{hex,-10}|{binary.PadLeft(10, '0')}|{num2,10:f2}|{num3,-10:f3}|");
        }
    }
}