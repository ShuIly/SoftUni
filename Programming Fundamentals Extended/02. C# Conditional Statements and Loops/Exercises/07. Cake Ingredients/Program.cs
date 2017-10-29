using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
	class Program
	{
		static void Main(string[] args)
		{
			int numIngredients = 0;
			string ingredient = Console.ReadLine();

			while (ingredient != "Bake!")
			{
				numIngredients++;
				Console.WriteLine($"Adding ingredient {ingredient}.");
				ingredient = Console.ReadLine();
			}

			Console.WriteLine($"Preparing cake with {numIngredients} ingredients.");
		}
	}
}
