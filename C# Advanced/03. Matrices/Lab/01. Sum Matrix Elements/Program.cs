using System;
using System.Linq;

namespace _01.Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] colRow = Console.ReadLine()
				.Split(new []{ ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

	        int col = colRow[0];

			int[][] matrix = new int[col][];
	        for (int i = 0; i < col; i++)
	        {
				matrix[i] = Console.ReadLine()
					.Split(new []{ ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
	        }

	        int sumMatrix = 0;
	        foreach (var row in matrix)
		        sumMatrix += row.Sum();

		    string result = $"{colRow[0]}\n{colRow[1]}\n{sumMatrix}\n";
	        Console.WriteLine(result);
        }
    }
}