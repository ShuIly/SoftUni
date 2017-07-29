using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Resizable_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			CreateResizableArray(4, 0, new int[4]);
		}

		// arrLength - size of array
		// index - how much elements we have pushed in it
		// arr - the array itself
		static void CreateResizableArray(int arrLength, int index, int[] arr)
		{
			string[] command = Console.ReadLine().Split();
			int[] currArr = new int[arrLength];

			for (int i = 0; i < index; i++)
			{
				currArr[i] = arr[i];
			}

			while (command[0] != "end")
			{
				if (command[0] == "push")
				{
					int num = int.Parse(command[1]);
					currArr[index] = num;
					index++;
				}
				else if (command[0] == "pop")
				{
					/* 
					I thought about using a string array and setting values to null
					but keeping an index value that remembers how much element we have
				    is pretty much the same.
					*/
					index--;
					currArr[index] = 0;
				}
				else if (command[0] == "removeAt")
				{
					int removePos = int.Parse(command[1]);
					for (int i = removePos + 1; i < index; i++)
					{
						currArr[i - 1] = currArr[i];
					}
					index--;
					currArr[index] = 0;
				}
				else if (command[0] == "clear")
				{ 
					// there really is no point to setting array values to 0
					// but that way the code looks cleaner
					for (int i = 0; i < index; i++)
					{
						currArr[i] = 0;
					}
					index = 0;
				}

				if (index == arrLength)
				{
					// if the index comes to the end, we call the same function 
					// but with a size that is two times bigger.
					CreateResizableArray(arrLength * 2, index, currArr);
					return;
				}

				 command = Console.ReadLine().Split();
			}

			for (int i = 0; i < index; i++)
			{
				Console.Write(currArr[i] + " ");
			}
		}
	}
}
