using System;

public class UltrasoftTyre : Tyre
{
    private const string SoftTyreName = "Ultrasoft";
    private const int MinDegradation = 30;

    public UltrasoftTyre(double hardness, double grip)
        : base(SoftTyreName, hardness)
    {
        this.Grip = grip;
    }

    public double Grip { get; }

    public override double Degradation
    {
        get => base.Degradation;
        protected set
        {
            if (value < MinDegradation)
            {
                throw new ArgumentException(OutputMessages.BlownTyre);
            }

            base.Degradation = value;
        }
    }

    public override void CompleteLap()
    {
        base.CompleteLap();
        this.Hardness -= this.Grip;
    }
}
