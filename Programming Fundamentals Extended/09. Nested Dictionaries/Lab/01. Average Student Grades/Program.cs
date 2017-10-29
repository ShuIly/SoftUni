using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Average_Student_Grades
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

			for (int i = 0; i < n; i++)
			{
				string[] studentInfo = Console.ReadLine().Split();
				string studentName = studentInfo[0];
				double studentGrade = double.Parse(studentInfo[1]);

				if (!studentGrades.ContainsKey(studentName))
				{
					studentGrades.Add(studentName, new List<double>());
				}
				studentGrades[studentName].Add(studentGrade);
			}

			foreach (KeyValuePair<string, List<double>> student in studentGrades)
			{
				List<double> gradesList = student.Value;
				double averageGrade = gradesList.Average();

				Console.Write("{0} -> ", student.Key);
				foreach (double grade in gradesList)
				{
					Console.Write("{0:F2} ", grade);
				}
				Console.WriteLine("(avg: {0:F2})", averageGrade);
			}
		}
	}
}
