using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMS_Typing
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string message = "";

			for (int i = 0; i < n; i++)
			{
				string phoneKey = Console.ReadLine();
				int keyLength = phoneKey.Length - 1;
				int firstKey = (int) Char.GetNumericValue(phoneKey[0]);

				if (firstKey > 1 && firstKey <= 7)
				{
					// when the user types 2222, the key letters will begin from start.
					while (keyLength > 3) keyLength /= 3;
					message += (char) ((firstKey - 2) * 3 + keyLength + 97);
				}
				else if (firstKey == 8 || firstKey == 9)
				{
					while (keyLength > 4) keyLength /= 4;
					message += (char) ((firstKey - 2) * 3 + keyLength + 98);
				}
				else if (firstKey == 0)
				{
					message += " ";
				}
			}
			Console.WriteLine(message);
		}
	}
}
