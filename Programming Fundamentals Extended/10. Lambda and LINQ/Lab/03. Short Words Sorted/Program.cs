using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Short_Words_Sorted
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> words = Console.ReadLine().ToLower()
				.Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, 
				StringSplitOptions.RemoveEmptyEntries)
				.Where(x => x.Length < 5).Distinct().OrderBy(x => x).ToList();
			Console.WriteLine(string.Join(", ", words));
		}
	}
}
