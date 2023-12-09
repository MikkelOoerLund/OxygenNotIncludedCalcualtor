namespace OxygenNotIncluded
{
    public class DietInfo
    {
        public int CurrentCalories { get; }
        public int CaloriesAtBirth { get; }
        public int CalorieConsumptionPerCycle { get; }

        public DietInfo(int currentCalories, int caloriesAtBirth, int calorieConsumptionPerCycle)
        {
            CurrentCalories = currentCalories;
            CaloriesAtBirth = caloriesAtBirth;
            CalorieConsumptionPerCycle = calorieConsumptionPerCycle;
        }
    }
}