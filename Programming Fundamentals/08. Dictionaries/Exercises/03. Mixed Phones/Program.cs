using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>(); 
			string[] currPhone = Console.ReadLine().Split();
			while (currPhone[0] != "Over")
			{
				try
				{
					long number = long.Parse(currPhone[2]);
					phonebook[currPhone[0]] = number;
				}
				catch
				{
					long number = long.Parse(currPhone[0]);
					phonebook[currPhone[2]] = number;
				}

				currPhone = Console.ReadLine().Split();
			}

			foreach (KeyValuePair<string, long> phone in phonebook)
			{
				Console.WriteLine($"{phone.Key} -> {phone.Value}");
			}
		}
	}
}
