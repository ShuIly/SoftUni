﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Largest_3_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
			Console.WriteLine(string.Join(" ", arr.OrderByDescending(x => x).Take(3)));
		}
	}
}
