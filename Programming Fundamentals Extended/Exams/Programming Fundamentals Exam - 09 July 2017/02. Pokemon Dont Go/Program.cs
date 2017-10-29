using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
			List<int> nums = new List<int>
				(Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray());

	        int sumRemovedElements = 0;
	        while (nums.Count > 0)
	        {
		        int index = int.Parse(Console.ReadLine());
		        int removedNum;
		        if (index < 0)
		        {
			        removedNum = nums[0];
			        nums[0] = nums[nums.Count - 1];
		        }
				else if (index >= nums.Count)
		        {
			        int lastElementIndex = nums.Count - 1;
			        removedNum = nums[lastElementIndex];
			        nums[lastElementIndex] = nums[0];
		        }
		        else
		        {
			        removedNum = nums[index];
			        nums.RemoveAt(index);
		        }

		        for (int i = 0; i < nums.Count; i++)
		        {
			        if (nums[i] <= removedNum)
				        nums[i] += removedNum;
					else
				        nums[i] -= removedNum;
		        }

		        sumRemovedElements += removedNum;
	        }

	        Console.WriteLine(sumRemovedElements);
        }
    }
}