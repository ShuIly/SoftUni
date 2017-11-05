using System;
using System.Linq;

namespace _07.Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
	        int n = int.Parse(Console.ReadLine());
			string[][] matrix1 = new string[n][];
			string[][] matrix2 = new string[n][];

	        for (int i = 0; i < n; i++)
	        {
		        matrix1[i] = Console.ReadLine()
					.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
	        }

	        int lastLength = 0;
	        bool matrixFit = true;

	        for (int i = 0; i < n; i++)
	        {
		        matrix2[i] = Console.ReadLine()
					.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries);

		        int currLength = matrix1[i].Length + matrix2[i].Length;
		        if (matrixFit && (lastLength == currLength || lastLength == 0))
			        lastLength = currLength;
		        else
			        matrixFit = false;
	        }

	        if (matrixFit)
	        {
		        for (int i = 0; i < n; i++)
		        {
			        string result = $"[{string.Join(", ", matrix1[i])}, {string.Join(", ", matrix2[i].Reverse())}]";
			        Console.WriteLine(result);
		        }
	        }
	        else
	        {
		        int totalNumCells = 0;
		        for (int i = 0; i < n; i++)
		        {
			        totalNumCells += matrix1[i].Length + matrix2[i].Length;
		        }

		        Console.WriteLine($"The total number of cells is: {totalNumCells}");
	        }
        }
    }
}