using _05.Mordor_s_Cruelty_Plan;
using _05.Mordor_s_Cruelty_Plan.Factories.Foods;
using _05.Mordor_s_Cruelty_Plan.Factories.Moods;

class Gandalf
{
    public Mood Mood => MoodFactory.GetMood(this.HappinessPoints);

    public int HappinessPoints { get; private set; }

    public void EatFood(Food food)
    {
        HappinessPoints += food.PointsOfHappiness;
    }
}
