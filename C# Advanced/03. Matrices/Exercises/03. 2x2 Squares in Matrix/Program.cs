using System;
using System.Linq;

namespace _03._2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] colRow = Console.ReadLine()
				.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			char[][] matrix = new char[colRow[0]][];

	        for (int i = 0; i < colRow[0]; i++)
	        {
		        matrix[i] = Console.ReadLine()
					.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(char.Parse)
					.ToArray();
	        }

	        int equalSquaresCount = 0;
	        for (int i = 1; i < matrix.Length; i++)
	        {
				for (int j = 1; j < matrix[i].Length; j++)
				{
					if (matrix[i][j] == matrix[i - 1][j - 1] &&
					    matrix[i][j] == matrix[i - 1][j] &&
					    matrix[i][j] == matrix[i][j - 1])
						equalSquaresCount++;
				}
	        }

	        Console.WriteLine(equalSquaresCount);
        }
    }
}