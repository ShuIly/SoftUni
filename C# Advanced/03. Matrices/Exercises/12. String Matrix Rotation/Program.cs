using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.String_Matrix_Rotation
{
	class Program
	{
		static void Main(string[] args)
		{
			int rotateGrad = Console.ReadLine()
				.Split(new[] { "Rotate(", ")" }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.First();

			rotateGrad %= 360;
			List<char[]> charList = new List<char[]>();

			int maxLength = 0;
			while (true)
			{
				string input = Console.ReadLine();
				if (input == "END")
					break;

				if (maxLength < input.Length)
					maxLength = input.Length;

				charList.Add(input.ToCharArray());
			}

			char[][] matrix = new char[charList.Count][];
			for (int i = 0; i < charList.Count; i++)
			{
				matrix[i] = new char[maxLength];
				for (int j = 0; j < charList[i].Length; j++)
					matrix[i][j] = charList[i][j];

				for (int j = charList[i].Length; j < maxLength; j++)
					matrix[i][j] = ' ';
			}

			int row = matrix.Length;
			int col = matrix[0].Length;
			string matrixLine = "";

			switch (rotateGrad)
			{
				case 0:
					for (int i = 0; i < row; i++)
					{
						for (int j = 0; j < col; j++)
							matrixLine += matrix[i][j];
						Console.WriteLine(matrixLine);
						matrixLine = "";
					}
					break;
				case 90:
					for (int i = 0; i < col; i++)
					{
						for (int j = row - 1; j >= 0; j--)
							matrixLine += matrix[j][i];
						Console.WriteLine(matrixLine);
						matrixLine = "";
					}
					break;
				case 180:
					for (int i = row - 1; i >= 0; i--)
					{
						for (int j = col - 1; j >= 0; j--)
							matrixLine += matrix[i][j];
						Console.WriteLine(matrixLine);
						matrixLine = "";
					}
					break;
				case 270:
					for (int i = col - 1; i >= 0; i--)
					{
						for (int j = 0; j < row; j++)
							matrixLine += matrix[j][i];
						Console.WriteLine(matrixLine);
						matrixLine = "";
					}
					break;
			}
		}
	}
}