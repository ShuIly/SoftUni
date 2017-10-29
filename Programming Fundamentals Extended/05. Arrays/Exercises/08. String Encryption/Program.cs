using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.String_Encryption
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				char letter = char.Parse(Console.ReadLine());
				Console.Write(Encrypt(letter));
			}
			Console.WriteLine();
		}
		
		static string Encrypt(char letter)
		{
			int toAscii = letter;
			int firstDigit = GetFirstDigit(toAscii);
			int lastDigit = GetLastDigit(toAscii);
			string result = firstDigit.ToString() + lastDigit.ToString();
			char appendStart = (char) (toAscii + lastDigit);
			char appendEnd = (char) (toAscii - firstDigit);
			result = appendStart.ToString() + result;
			result += appendEnd.ToString();

			return result;
		}

		static int GetFirstDigit(int num)
		{
			while (num >= 10)
				num /= 10;

			return num;
		}

		static int GetLastDigit(int num)
		{
			return num % 10;
		}
	}
}