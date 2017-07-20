using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine(
                $"Name: {name}\n" +
                $"Age: {age}\n" +
                $"Employee ID: {employeeID:D8}\n" +
                $"Salary: {salary:f2}\n"
                );
        }
    }
}
