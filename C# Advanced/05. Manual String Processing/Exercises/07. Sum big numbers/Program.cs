using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _07.Sum_big_numbers
{
	class LargeInteger
	{
		public string Value { get; set; }

		public LargeInteger(string numStr)
		{
			Value = numStr.TrimStart('0');
		}

		public void Sum(string integer)
		{
			integer = integer.TrimStart('0');
			bool incrementNextInteger = false;

			int maxLength = Math.Max(Value.Length, integer.Length) + 1;

			Value = Value.PadLeft(maxLength, '0');
			integer = integer.PadLeft(maxLength, '0');

			char[] charArr = new char[maxLength];

			for (int i = maxLength - 1; i >= 0; --i)
			{
				char digitSum = (char)(Value[i] + integer[i] - '0');

				if (incrementNextInteger)
				{
					digitSum++;
					incrementNextInteger = false;
				}

				if (digitSum > '9')
				{
					digitSum -= (char)10;
					incrementNextInteger = true;
				}

				charArr[i] = digitSum;
			}

			if (incrementNextInteger)
			{
				charArr[0] = '1';
			}

			Value = new string(charArr).TrimStart('0');
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			string num1 = Console.ReadLine();
			string num2 = Console.ReadLine();

			LargeInteger largeInt = new LargeInteger(num1);
			largeInt.Sum(num2);

			Console.WriteLine(largeInt.Value);
		}
	}
}