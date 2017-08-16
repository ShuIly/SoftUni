using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSON_Stringify
{
	class Student
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public List<int> Grades { get; set; }

		public Student(string name, int age, List<int> grades)
		{
			Name = name;
			Age = age;

			Grades = new List<int>();
			for (int i = 0; i < grades.Count; i++)
			{
				Grades.Add(grades[i]);
			}
		}

		public override string ToString()
		{
			string result = $"{{name:\"{Name}\",age:{Age},grades:[{string.Join(", ", Grades)}]}}";
			return result;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> studentsList = new List<Student>();
			string input = Console.ReadLine();
			while (input != "stringify")
			{
				string[] inputTokens = input
					.Split(new char[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

				List<int> grades = new List<int>();
				for (int i = 2; i < inputTokens.Length; i++)
				{
					grades.Add(int.Parse(inputTokens[i]));
				}

				string name = inputTokens[0];
				int age = int.Parse(inputTokens[1]);

				Student student = new Student(name, age, grades);
				studentsList.Add(student);

				input = Console.ReadLine();
			}

			Console.WriteLine($"[{string.Join(",", studentsList)}]");
		}
	}
}
