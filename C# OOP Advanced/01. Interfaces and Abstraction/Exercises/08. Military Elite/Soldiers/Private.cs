using System;

namespace Soldiers.Private
{
    public class Private : Soldier
    {
        private double salary;

        public double Salary
        {
            get => this.salary;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(this.Salary)} cannot be negative.");
                }

                this.salary = value;
            }
        }

        public Private(string id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.Salary:F2}";
        }
    }
}
