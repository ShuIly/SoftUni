using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Delimiter
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] str = Console.ReadLine().Split();
			int strLength = str.Length;

			int sum = 0;
			int divider = 0;
			
			for (int i = 0; i < strLength; i++)
			{
				int substringLength = str[i].Length;
				divider += substringLength;
				for (int j = 0; j < substringLength; j++)
				{
					sum += (int) str[i][j];
				}
			}

			char delimiter = Char.ToUpper((char) (sum / divider));
			string strDelimiter = new string(delimiter, 1);

			// because string.Join requires string as a delimiter we have to convert delimiter
			// to string with new string().
			Console.WriteLine(string.Join(strDelimiter, str));
		}
	}
}
