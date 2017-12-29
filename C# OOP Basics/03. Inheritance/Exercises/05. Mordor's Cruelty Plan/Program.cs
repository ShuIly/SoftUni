using System;
using _05.Mordor_s_Cruelty_Plan.Factories;
using _05.Mordor_s_Cruelty_Plan.Factories.Foods;

class Program
{
    static void Main(string[] args)
    {
        Gandalf gandalf = new Gandalf();

        string[] foodArr = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var foodName in foodArr)
        {
            Food food = FoodFactory.GetFood(foodName);
            gandalf.EatFood(food);
        }

        Console.WriteLine(gandalf.HappinessPoints + "\n" + gandalf.Mood);
    }
}
