using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Base
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> employeePosition = new Dictionary<string, string>();
			Dictionary<string, double> employeeSalary = new Dictionary<string, double>();
			Dictionary<string, int> employeeAge = new Dictionary<string, int>();

			string employeeCommand = Console.ReadLine();
			while (employeeCommand != "filter base")
			{
				string[] employeeInfo = employeeCommand.Split();
				string employeeName = employeeInfo[0];
				string employeeStatus = employeeInfo[2];

				int age = 0;
				double salary = 0;
				string position = "";

				if (int.TryParse(employeeStatus, out age))
				{
					employeeAge[employeeName] = age;
				}
				else if (double.TryParse(employeeStatus, out salary))
				{
					employeeSalary[employeeName] = salary;
				}
				else
				{
					position = employeeStatus;
					employeePosition[employeeName] = position;
				}

				employeeCommand = Console.ReadLine();
			}

			string getStatus = Console.ReadLine();
			switch (getStatus)
			{
				case "Salary":
					foreach (KeyValuePair<string, double> employee in employeeSalary)
					{
						Console.WriteLine($"Name: {employee.Key}");
						Console.WriteLine($"Salary: {employee.Value:F2}");
						Console.WriteLine("====================");
					}
					break;
				case "Age":
					foreach (KeyValuePair<string, int> employee in employeeAge)
					{
						Console.WriteLine($"Name: {employee.Key}");
						Console.WriteLine($"Age: {employee.Value}");
						Console.WriteLine("====================");
					}
					break;
				case "Position":
					foreach (KeyValuePair<string, string> employee in employeePosition)
					{
						Console.WriteLine($"Name: {employee.Key}");
						Console.WriteLine($"Position: {employee.Value}");
						Console.WriteLine("====================");
					}
					break;
			}
		}
	}
}
