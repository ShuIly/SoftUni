using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shoot_List_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();

			bool keepShooting = true;
			int lastShot = 0;
			while (keepShooting)
			{
				string command = Console.ReadLine();
				if (command == "bang")
				{
					if (!list.Any())
					{
						keepShooting = false;
						Console.WriteLine($"nobody left to shoot! last one was {lastShot}");
					}
					else
					{
						decimal average = FindAverage(list);
						for (int i = list.Count - 1; i >= 0; i--)
						{
							int currElement = list[i];
							if (currElement <= average)
							{
								Console.WriteLine($"shot {currElement}");
								lastShot = currElement;
								decrementList(list);
								list.RemoveAt(i);
								break;
							}
						}
					}
				}
				else if (command == "stop")
				{
					keepShooting = false;
					if (!list.Any())
					{
						Console.WriteLine($"you shot them all. last one was {lastShot}");
					}
					else
					{
						list.Reverse();
						Console.WriteLine("survivors: {0}", string.Join(" ", list));
					}
				}
				else
				{
					list.Add(int.Parse(command));
				}
			}

			{

			}
		}

		static decimal FindAverage(List<int> list)
		{
			int sumElements = 0;
			int listCount = list.Count;

			for (int i = 0; i < listCount; i++)
			{
				sumElements += list[i];
			}

			decimal average = (decimal)sumElements / listCount;
			return average;
		}

		static void decrementList(List<int> list)
		{
			int listCount = list.Count;
			for (int i = 0; i < listCount; i++)
			{
				list[i]--;
			}
		}
	}
}
