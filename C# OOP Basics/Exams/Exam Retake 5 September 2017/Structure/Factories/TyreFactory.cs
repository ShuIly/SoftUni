using System;

public static class TyreFactory
{
    public static Tyre GetTyre(string[] tyreArgs)
    {
        string type = tyreArgs[0];
        double hardness = double.Parse(tyreArgs[1]);

        switch (type)
        {
            case "Hard":
                return new HardTyre(hardness);
            case "Ultrasoft":
                double grip = double.Parse(tyreArgs[2]);
                return new UltrasoftTyre(hardness, grip);
            default:
                throw new ArgumentException(OutputMessages.InvalidTyreType);
        }
    }
}
