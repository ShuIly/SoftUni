using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Insertion_Sort_Using_List
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

			list = InsertionSort(list);
			Console.WriteLine(string.Join(" ", list));
		}

		static List<int> InsertionSort(List<int> list)
		{
			List<int> resultList = new List<int>();
			for (int i = 0; i < list.Count; i++)
			{
				int elementToInsert = list[i];
				bool hasInserted = false;
				for (int j = 0; j < resultList.Count; j++)
				{
					int currElement = resultList[j];
					if (elementToInsert < currElement)
					{
						resultList.Insert(j, elementToInsert);
						hasInserted = true;
						break;
					}
				}
				if (!hasInserted)
				{
					resultList.Add(elementToInsert);
				}
			}
			return resultList;
		}
		
	}
}
