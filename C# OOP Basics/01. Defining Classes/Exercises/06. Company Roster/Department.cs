using System;
using System.Collections.Generic;

class Department
{
    private double totalSalary;
    private List<Employee> employees;

    public String Name { get; set; }

    public double AverageSalary => totalSalary / employees.Count;

    public List<Employee> Employees => this.employees;

    public Department(string name)
    {
        Name = name;
        employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        if (employee == null)
        {
            throw new ArgumentNullException();
        }

        employees.Add(employee);
        totalSalary += employee.Salary;
    }
}
