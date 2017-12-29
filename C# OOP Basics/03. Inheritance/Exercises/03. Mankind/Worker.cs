using System;

class Worker : Human
{
    private const double MinWeekSalary = 10;
    private const int MinWorkHoursPerDay = 1;
    private const int MaxWorkHoursPerDay = 12;

    private double weekSalary;
    private double workHoursPerDay;

    public double WeekSalary
    {
        get => this.weekSalary;
        set
        {
            if (value < MinWeekSalary)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(weekSalary)}");
            }

            this.weekSalary = value;
        }
    }

    public double WorkHoursPerDay
    {
        get => this.workHoursPerDay;
        set
        {
            if (value < MinWorkHoursPerDay || value > MaxWorkHoursPerDay)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(workHoursPerDay)}");
            }

            this.workHoursPerDay = value;
        }
    }

    public double HourSalary => (this.WeekSalary / 5) / this.WorkHoursPerDay;

    public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public override string ToString()
    {
        return base.ToString() + "\n" +
               $"Week Salary: {this.WeekSalary:F2}\n" +
               $"Hours per day: {this.WorkHoursPerDay:F2}\n" +
               $"Salary per hour: {this.HourSalary:F2}";
    }
}
