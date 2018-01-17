﻿using System;

public class Citizen : IPerson, IResident
{
    private string name;
    private string country;
    private int age;

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

    public string Country
    {
        get => this.country;
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.Country)} cannot be null or whitespace.");
            }

            this.country = value;
        }
    }

    public int Age
    {
        get => this.age;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.Age)} cannot be negative.");
            }

            this.age = value;
        }
    }

    public Citizen(string name, string country, int age)
    {
        this.Name = name;
        this.Country = country;
        this.Age = age;
    }

    string IPerson.GetName()
    {
        return this.Name;
    }

    string IResident.GetName()
    {
        return "Mr/Ms/Mrs";
    }
}