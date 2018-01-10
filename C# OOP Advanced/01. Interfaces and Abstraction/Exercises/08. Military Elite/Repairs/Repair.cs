using System;

namespace _08.Military_Elite.Soldiers.Repairs
{
    public class Repair
    {
        private string partName;
        private int hoursWorked;

        public string PartName
        {
            get => this.partName;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(this.PartName)} cannot be null or whitespace.");
                }

                this.partName = value;
            }
        }

        public int HoursWorked
        {
            get => this.hoursWorked;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(HoursWorked)} cannot be negative.");
                }

                this.hoursWorked = value;
            }
        }

        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}
