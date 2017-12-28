using System;
using System.Runtime.InteropServices;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public string FirstName
    {
        get => this.firstName;
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Value cannot be less than 3 symbols");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get => this.lastName;
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Value cannot be less than 3 symbols");
            }

            this.lastName = value;
        }
    }

    public int Age
    {
        get => this.age;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or negative integer");
            }

            this.age = value;
        }
    }

    public double Salary
    {
        get => this.salary;
        set
        {
            if (value < 460)
            {
                throw new ArgumentException("Salary cannot be less than 460.0");
            }

            this.salary = value;
        }
    }

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public void IncreaseSalary(double bonus)
    {
        if (this.Age < 30)
        {
            bonus /= 2;
        }

        double bonusSalary = this.Salary * bonus / 100;
        this.Salary += bonusSalary;
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this.Salary:F2} leva";
    }
}