using System;

namespace _08.Military_Elite.Soldiers.Missions
{
    public class Mission
    {
        private string name;
        private string state;

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(this.Name)} cannot be null or whitespace.");
                }

                this.name = value;
            }
        }

        public string State
        {
            get => this.state;
            private set
            {
                if (!(value == "inProgress" || value == "Finished"))
                {
                    throw new ArgumentException($"Invalid {nameof(this.State)}.");
                }

                this.state = value;
            }
        }

        public Mission(string name, string state)
        {
            this.Name = name;
            this.State = state;
        }

        public override string ToString()
        {
            return $"Code Name: {this.Name} State: {this.State}";
        }
    }
}
