using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] numbers = Console.ReadLine().Split();
			string[] names = Console.ReadLine().Split();
			string[] command = Console.ReadLine().Split();

			while (command[0] != "done")
			{
				int getId = -1;
				bool callNumber = false;

				for (int i = 0; i < names.Length; i++)
				{
					if (command[1] == names[i])
					{
						getId = i;
						callNumber = true;
						break;
					}
					else if (command[1] == numbers[i])
					{
						getId = i;
						callNumber = false;
						break;
					}
				}

				if (command[0] == "call")
				{
					if (callNumber == true)
					{
						Console.WriteLine("calling {0}...", numbers[getId]);
					}
					else
					{
						Console.WriteLine("calling {0}...", names[getId]);
					}

					int sumOfDigits = GetSumOfDigits(numbers[getId]);

					if (sumOfDigits % 2 == 0)
					{
						int timeInSeconds = sumOfDigits;
						int minutes = timeInSeconds / 60;
						int seconds = timeInSeconds % 60;

						Console.WriteLine("call ended. duration: {0:D2}:{1:D2}", minutes, seconds);
					}
					else
					{
						Console.WriteLine("no answer");
					}
				}
				else if (command[0] == "message")
				{
					if (callNumber == false)
					{
						Console.WriteLine("sending sms to {0}...", names[getId]);
					}
					else
					{
						Console.WriteLine("sending sms to {0}...", numbers[getId]);
					}

					int numDifference = GetSumOfDigits(numbers[getId]);

					if (numDifference % 2 == 0)
					{
						Console.WriteLine("meet me there");
					}
					else
					{
						Console.WriteLine("busy");
					}
				}
				command = Console.ReadLine().Split();
			}
		}

		static int GetSumOfDigits(string num)
		{
			int result = 0;

			for (int i = 0; i < num.Length; i++)
			{
				if (num[i] >= '0' && num[i] <= '9')
				{
					// because GetNumericValue returns double we have to cast to int
					result += (int)Char.GetNumericValue(num[i]);
				}
			}

			return result;
		}
	}
}
