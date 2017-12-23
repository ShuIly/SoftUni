using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var departments = new Dictionary<string, Department>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] employeeArgs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = employeeArgs[0];
            double salary = double.Parse(employeeArgs[1]);
            string position = employeeArgs[2];
            string department = employeeArgs[3];

            if (!departments.ContainsKey(department))
            {
                departments.Add(department, new Department(department));
            }

            Employee employee = new Employee(name, salary, position, department);

            if (employeeArgs.Length == 5)
            {
                if (int.TryParse(employeeArgs[4], out int age))
                {
                    employee = new Employee(name, salary, position, department, age);
                }
                else
                {
                    string email = employeeArgs[4];
                    employee = new Employee(name, salary, position, department, email);
                }
            }

            if (employeeArgs.Length == 6)
            {
                string email = employeeArgs[4];
                int age = int.Parse(employeeArgs[5]);

                employee = new Employee(name, salary, position, department, email, age);
            }

            departments[department].AddEmployee(employee);
        }

        Department bestAvgSalaryDepartment = departments.Values
            .OrderByDescending(d => d.AverageSalary).First();

        Console.WriteLine($"Highest Average Salary: {bestAvgSalaryDepartment.Name}");
        foreach (var employee in bestAvgSalaryDepartment.Employees
            .OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
        }
    }
}