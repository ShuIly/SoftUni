using System;
using System.Linq;

namespace _03.Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] nums = Console.ReadLine()
				.Split(new []{ ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int[][] matrix = new int[3][];
			int[] matrixSizes = new int[3];

	        foreach (int num in nums)
	        {
		        int remainder = Math.Abs(num % 3);
		        matrixSizes[remainder]++;
	        }

	        for (int i = 0; i < 3; i++)
	        {
		        matrix[i] = new int[matrixSizes[i]];
	        }

			int[] offsets = new int[3];
	        foreach (int num in nums)
	        {
		        int remainder = Math.Abs(num % 3);
		        int index = offsets[remainder];
		        matrix[remainder][index] = num;
		        offsets[remainder]++;
	        }

	        string result = "";
	        foreach (int[] row in matrix)
	        {
		        result += string.Join(" ", row) + "\n";
	        }

	        Console.WriteLine(result);
        }
    }
}