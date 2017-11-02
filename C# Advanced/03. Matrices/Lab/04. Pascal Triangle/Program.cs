using System;

namespace _04.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
	        int n = int.Parse(Console.ReadLine());
			int[][] matrix = new int[n][];

			matrix[0] = new int[1];
	        matrix[0][0] = 1;

	        for (int i = 1; i < n; i++)
	        {
				matrix[i] = new int[i + 1];
		        matrix[i][0] = 1;
		        matrix[i][i] = 1;

		        for (int j = 1; j < i; j++)
		        {
			        matrix[i][j] = matrix[i - 1][j] + matrix[i - 1][j - 1];
		        }
	        }

	        string result = "";
	        foreach (int[] row in matrix)
	        {
		        result += $"{string.Join(" ", row)}\n";
	        }

	        Console.WriteLine(result);
        }
    }
}