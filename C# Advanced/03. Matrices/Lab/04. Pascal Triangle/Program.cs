using System;

namespace _04.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
	        long n = long.Parse(Console.ReadLine());
			long[][] matrix = new long[n][];

			matrix[0] = new long[1];
	        matrix[0][0] = 1;

	        for (long i = 1; i < n; i++)
	        {
				matrix[i] = new long[i + 1];
		        matrix[i][0] = 1;
		        matrix[i][i] = 1;

		        for (long j = 1; j < i; j++)
		        {
			        matrix[i][j] = matrix[i - 1][j] + matrix[i - 1][j - 1];
		        }
	        }

	        string result = "";
	        foreach (long[] row in matrix)
	        {
		        result += $"{string.Join(" ", row)}\n";
	        }

	        Console.WriteLine(result);
        }
    }
}