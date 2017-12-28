using System;

class Player
{
    private const int MinStat = 0;
    private const int MaxStat = 100;

    private string name;
    private double endurance;
    private double sprint;
    private double dribble;
    private double passing;
    private double shooting;


    public string Name
    {
        get => this.name;
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }

            this.name = value;
        }
    }

    public double Endurance
    {
        get => this.endurance;
        private set
        {
            if (value < MinStat || value > MaxStat)
            {
                throw new ArgumentException($"{nameof(Endurance)} should be between {MinStat} and {MaxStat}.");
            }

            this.endurance = value;
        }
    }

    public double Sprint
    {
        get => this.sprint;
        private set
        {
            if (value < MinStat || value > MaxStat)
            {
                throw new ArgumentException($"{nameof(Sprint)} should be between {MinStat} and {MaxStat}.");
            }

            this.sprint = value;
        }
    }

    public double Dribble
    {
        get => this.dribble;
        private set
        {
            if (value < MinStat || value > MaxStat)
            {
                throw new ArgumentException($"{nameof(Dribble)} should be between {MinStat} and {MaxStat}.");
            }

            this.dribble = value;
        }
    }

    public double Passing
    {
        get => this.passing;
        private set
        {
            if (value < MinStat || value > MaxStat)
            {
                throw new ArgumentException($"{nameof(Passing)} should be between {MinStat} and {MaxStat}.");
            }

            this.passing = value;
        }
    }

    public double Shooting
    {
        get => this.shooting;
        private set
        {
            if (value < MinStat || value > MaxStat)
            {
                throw new ArgumentException($"{nameof(Shooting)} should be between {MinStat} and {MaxStat}.");
            }

            this.shooting = value;
        }
    }

    public double OverallSkill { get; }

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
        this.OverallSkill = (this.endurance + this.sprint + this.dribble + this.passing + this.shooting) / 5;
    }
}
