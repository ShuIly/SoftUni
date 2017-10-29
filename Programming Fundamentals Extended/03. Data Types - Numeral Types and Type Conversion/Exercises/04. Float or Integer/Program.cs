using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Float_or_Integer
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal n = decimal.Parse(Console.ReadLine());
			Console.WriteLine(Math.Round(n));
		}
	}
}
