using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
	abstract class Animal
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public static Animal CreateAnimal(string input)
		{
			string[] inputTokens = input.Split();
			string animalType = inputTokens[0];
			string animalName = inputTokens[1];
			int animalAge = int.Parse(inputTokens[2]);

			Animal animal = null;
			switch (animalType)
			{
				case "Dog":
					animal = Dog.CreateDog(int.Parse(inputTokens[3]));
					break;
				case "Cat":
					animal = Cat.CreateCat(int.Parse(inputTokens[3]));
					break;
				case "Snake":
					animal = Snake.CreateSnake(int.Parse(inputTokens[3]));
					break;
			}

			animal.Name = animalName;
			animal.Age = animalAge;

			return animal;
		}

		public abstract void Talk();
	}

	class Dog : Animal
	{
		public int NumLegs { get; set; }

		public static Dog CreateDog(int numLegs)
		{
			Dog d = new Dog()
			{
				NumLegs = numLegs
			};

			return d;
		}

		override public void Talk()
		{
			Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
		}

		public override string ToString()
		{
			string result = string.Format($"Dog: {Name}, Age: {Age}, Number Of Legs: {NumLegs}");
			return result;
		}
	}
	class Cat : Animal
	{
		public int IQ { get; set; }

		public static Cat CreateCat(int iq)
		{
			Cat c = new Cat()
			{
				IQ = iq
			};

			return c;
		}

		override public void Talk()
		{
			Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
		}

		public override string ToString()
		{
			string result = string.Format($"Cat: {Name}, Age: {Age}, IQ: {IQ}");
			return result;
		}
	}
	class Snake : Animal
	{
		public int Cruelty { get; set; }

		public static Snake CreateSnake(int cruelty)
		{
			Snake s = new Snake()
			{
				Cruelty = cruelty
			};

			return s;
		}

		override public void Talk()
		{
			Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
		}

		public override string ToString()
		{
			string result = string.Format($"Snake: {Name}, Age: {Age}, Cruelty: {Cruelty}");
			return result;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var animalList = new List<Animal>();
			string input = Console.ReadLine();

			while (input != "I'm your Huckleberry")
			{
				string[] inputTokens = input.Split();
				if (inputTokens[0] == "talk")
				{
					string animalName = inputTokens[1];
					Animal talkAnimal = animalList.Find(a => a.Name == animalName);
					talkAnimal.Talk();
				}
				else
				{
					animalList.Add(Animal.CreateAnimal(input));
				}
				input = Console.ReadLine();
			}

			foreach (var animal in animalList
				.Where(a => a is Dog))
			{
				Console.WriteLine(animal);
			}

			foreach (var animal in animalList
				.Where(a => a is Cat))
			{
				Console.WriteLine(animal);
			}

			foreach (var animal in animalList
				.Where(a => a is Snake))
			{
				Console.WriteLine(animal);
			}
		}
	}
}
