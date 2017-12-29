
namespace _05.Mordor_s_Cruelty_Plan
{
    using Factories.Moods;

    class MoodFactory
    {
        private const int AngryMaxPoints = -6;
        private const int SadMaxPoints = 0;
        private const int HappyMaxPoints = 15;

        public static Mood GetMood(int happinessPoints)
        {
            if (happinessPoints <= AngryMaxPoints)
            {
                return new Angry(happinessPoints);
            }

            if (happinessPoints <= SadMaxPoints)
            {
                return new Sad(happinessPoints);
            }

            if (happinessPoints <= HappyMaxPoints)
            {
                return new Happy(happinessPoints);
            }

            return new JavaScript(happinessPoints);
        }
    }
}
