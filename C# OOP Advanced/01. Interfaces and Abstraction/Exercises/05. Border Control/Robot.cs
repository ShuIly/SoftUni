using System;

class Robot : IIdentifiable
{
    private string model;
    private string id;

    public string Model
    {
        get => this.model;
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.Model)} cannot be null or whitespace.");
            }

            this.model = value;
        }
    }

    public string Id
    {
        get => this.id;
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.Id)} cannot be null or whitespace.");
            }

            this.id = value;
        }
    }

    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }
}
