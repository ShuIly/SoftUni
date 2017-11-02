using System;
using System.Linq;

namespace _02.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
	        int n = int.Parse(Console.ReadLine());
			int[][] matrix = new int[n][];

	        for (int i = 0; i < n; i++)
	        {
		        matrix[i] = Console.ReadLine()
					.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
	        }

	        int sumTopToBottom = 0;
	        for (int i = 0, j = 0; i < n; i++, j++)
		        sumTopToBottom += matrix[i][j];

	        int sumBottomToTop = 0;
	        for (int i = n - 1, j = 0; i >= 0; i--, j++)
		        sumBottomToTop += matrix[i][j];

	        Console.WriteLine(Math.Abs(sumBottomToTop - sumTopToBottom));
        }
    }
}