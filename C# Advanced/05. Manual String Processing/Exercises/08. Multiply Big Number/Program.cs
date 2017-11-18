using System;

namespace _08.Multiply_Big_Number
{
	/*
	 * This is more than the exercise asked for:
	 * Second number can be larger than one digit and as big as a string allows it to.
	 * If you want simple working solution I recommend looking somewhere else.
	 */
	class LargeInteger
	{
		public string Value { get; set; }

		public LargeInteger(string numStr)
		{
			Value = numStr.TrimStart('0');
		}

		public LargeInteger()
		{
			Value = "0";
		}

		public void Sum(string numStr)
		{
			numStr = numStr.TrimStart('0');
			bool incrementNextInteger = false;

			int maxLength = Math.Max(Value.Length, numStr.Length) + 1;
			char[] charArr = new char[maxLength];

			Value = Value.PadLeft(maxLength, '0');
			numStr = numStr.PadLeft(maxLength, '0');

			for (int i = maxLength - 1; i >= 0; --i)
			{
				char digitSum = (char)(Value[i] + numStr[i] - '0');

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

		public void Multiply(string num1, string num2)
		{
			num1 = num1.TrimStart('0');
			num2 = num2.TrimStart('0');

			int maxLength = Math.Max(num1.Length, num2.Length) + 1;

			num1 = num1.PadLeft(maxLength, '0');
			num2 = num2.PadLeft(maxLength, '0');

			for (int i = maxLength - 1, offset = 0; i > 0; i--, offset++)
			{
				char[] charArr = new char[maxLength];

				int addDigit = (int)Char.GetNumericValue(num1[i]);
				if (addDigit == 0)
					continue;

				int addToNextDigit = 0;
				bool incrementNextInteger = false;
				for (int j = maxLength - 1; j >= 0; --j)
				{
					int currDigit = (int)Char.GetNumericValue(num2[j]);
					string digitSum = (currDigit * addDigit).ToString();
					charArr[j] = (char)(digitSum[digitSum.Length - 1] + addToNextDigit);

					if (charArr[j] > '9')
					{
						charArr[j] -= (char) 10;
						incrementNextInteger = true;
					}

					if (digitSum.Length == 2)
					{
						addToNextDigit = (int)Char.GetNumericValue(digitSum[0]);
						if (incrementNextInteger)
						{
							addToNextDigit++;
							incrementNextInteger = false;
						}
					}
					else
					{
						addToNextDigit = 0;
					}
				}

				if (addToNextDigit > 0)
				{
					charArr[0] = (char)(addToNextDigit + '0');
				}

				string result = new string(charArr).TrimStart('0');
				string padding = new string('0', offset);

				// Example: 123000
				// 123 - result
				// 000 - padding
				Sum(result + padding);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			string num1 = Console.ReadLine();
			string num2 = Console.ReadLine();

			LargeInteger largeInt = new LargeInteger();
			largeInt.Multiply(num2, num1);

			Console.WriteLine(largeInt.Value);
		}
	}
}