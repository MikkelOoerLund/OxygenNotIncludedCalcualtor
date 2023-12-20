namespace OxygenNotIncluded
{
    public class WildnessRate
    {
        public int GroomedRate { get; }
        public int WildernessRate { get; }

        public WildnessRate(int wildernessRate, int groomedRate)
        {
            GroomedRate = groomedRate;
            WildernessRate = wildernessRate;
        }
    }
}