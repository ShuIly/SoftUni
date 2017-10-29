using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Order_by_Age
{
	class Person
	{
		public string Name { get; set; }
		public string ID { get; set; }
		public int Age { get; set; }

		public Person(string name, string id, int age)
		{
			Name = name;
			ID = id;
			Age = age;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Person> peopleList = new List<Person>();
			string input = Console.ReadLine();
			while (input != "End")
			{
				string[] inputTokens = input.Split();
				string name = inputTokens[0];
				string id = inputTokens[1];
				int age = int.Parse(inputTokens[2]);

				Person person = new Person(name, id, age);
				peopleList.Add(person);

				input = Console.ReadLine();
			}

			foreach (var person in peopleList
				.OrderBy(p => p.Age))
			{
				Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
			}
		}
	}
}
