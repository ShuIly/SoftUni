using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Data_Overflow
{
	class Program
	{
		static void Main(string[] args)
		{
			ulong bigNum = ulong.Parse(Console.ReadLine());
			ulong smallNum = ulong.Parse(Console.ReadLine());

			if (bigNum < smallNum)
			{
				ulong temp = bigNum;
				bigNum = smallNum;
				smallNum = temp;
			}

			string bigNumType = checkType(bigNum);
			string smallNumType = checkType(smallNum);

			ulong smallMaxValue = checkMaxValue(smallNumType);
			int overflow = (int) Math.Round((decimal) bigNum / smallMaxValue);

			Console.WriteLine($"bigger type: {bigNumType}");
			Console.WriteLine($"smaller type: {smallNumType}");
			Console.WriteLine($"{bigNum} can overflow {smallNumType} {overflow} times");

		}
		static string checkType (ulong num)
		{
			if (num > uint.MaxValue)
			{
				return "ulong";
			}
			else if (num > ushort.MaxValue)
			{
				return "uint";
			}
			else if (num > byte.MaxValue)
			{
				return "ushort";
			}
			else
			{
				return "byte";
			}
		}
		static ulong checkMaxValue (string type)
		{
			switch (type)
			{
				case "ulong":
					return ulong.MaxValue;
				case "uint":
					return uint.MaxValue;
				case "ushort":
					return ushort.MaxValue;
				case "byte":
					return byte.MaxValue;
				default:
					return 0;
			}
		}
	}
}
