using System;
using System.Linq;

class Student : Human
{
    private const int MinFacultyNumberLength = 5;
    private const int MaxFacultyNumberLength = 10;

    private string facultyNumber;

    public string FacultyNumber
    {
        get => this.facultyNumber;
        set
        {
            if (value.Length < MinFacultyNumberLength || value.Length > MaxFacultyNumberLength ||
                value.Any(c => !Char.IsLetterOrDigit(c)))
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            this.facultyNumber = value;
        }
    }

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public override string ToString()
    {
        return base.ToString() + "\n" +
               $"Faculty number: {this.FacultyNumber}";
    }
}
