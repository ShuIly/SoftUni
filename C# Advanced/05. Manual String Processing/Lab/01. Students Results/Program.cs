using System;
using System.Collections.Generic;

namespace _01.Students_Results
{
	class Student
	{
		public string Name { get; set; }
		public double CAdvGrade { get; set; }
		public double COOPGrade { get; set; }
		public double AdvOOPGrade { get; set; }

		public Student(string name, double cAdvGrade, double coopGrade, double advOopGrade)
		{
			Name = name;
			CAdvGrade = cAdvGrade;
			COOPGrade = coopGrade;
			AdvOOPGrade = advOopGrade;
		}

		public double GetAverageGrade()
		{
			return (CAdvGrade + COOPGrade + AdvOOPGrade) / 3;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
	        var students = new Dictionary<string, Student>();
	        int n = int.Parse(Console.ReadLine());

	        for (int i = 0; i < n; i++)
	        {
		        string[] inputArgs = Console.ReadLine()
					.Split(new []{ ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
		        string studentName = inputArgs[0];
		        double cAdvGrade = double.Parse(inputArgs[1]);
		        double coopGrade = double.Parse(inputArgs[2]);
		        double advOopGrade = double.Parse(inputArgs[3]);

				students[studentName] = new Student(studentName, cAdvGrade, coopGrade, advOopGrade);
	        }

	        Console.WriteLine("Name      |   CAdv|   COOP| AdvOOP|Average|");
	        foreach (var student in students.Values)
	        {
		        Console.WriteLine($"{student.Name,-10}|{student.CAdvGrade,7:f2}|{student.COOPGrade,7:f2}|{student.AdvOOPGrade,7:f2}|{student.GetAverageGrade(),7:f4}|");
	        }
        }
    }
}