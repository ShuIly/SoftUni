using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JSON_Parse
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
			string result = ""; 
			if (Grades.Count > 0)
			{
				result = $"{Name} : {Age} -> {string.Join(", ", Grades)}";
			}
			else
			{
				result = $"{Name} : {Age} -> None";
			}
			return result;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Student> studentsList = new List<Student>();
			string input = Console.ReadLine();
			string[] students = input
				.Split(new string[] { "]},{" }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var student in students)
			{
				string[] studentInfo = student
					.Split(new string[] { " ", ":", "\"", ",", "[", "]", "}", "{", "]", "name", "age", "grades" },
					StringSplitOptions.RemoveEmptyEntries);

				string name = studentInfo[0];
				int age = int.Parse(studentInfo[1]);

				List<int> grades = new List<int>();
				for (int i = 2; i < studentInfo.Length; i++)
				{
					grades.Add(int.Parse(studentInfo[i]));
				}

				Student s = new Student(name, age, grades);
				studentsList.Add(s);
			}

			Console.WriteLine(string.Join(Environment.NewLine, studentsList));
		}
	}
}
