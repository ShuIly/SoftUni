using System;
using System.Linq;

namespace _01.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] colRow = Console.ReadLine()
				.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

	        int col = colRow[1];
	        int row = colRow[0];
			string[][] matrix = new string[row][];

	        for (int i = 0; i < row; i++)
	        {
				char[] charArr = new char[3];
		        char edgeChar = (char) ('a' + i);

		        charArr[0] = edgeChar;
		        charArr[2] = edgeChar;

		        matrix[i] = new string[col];

		        for (int j = 0; j < col; j++)
		        {
			        charArr[1] = (char) (edgeChar + j);
			        matrix[i][j] = new string(charArr);
		        }
	        }

	        string result = "";
	        foreach (string[] matrixRow in matrix)
	        {
		        result += $"{string.Join(" ", matrixRow)}\n";
	        }

	        Console.WriteLine(result);
        }
    }
}