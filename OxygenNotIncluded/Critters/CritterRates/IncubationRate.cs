namespace OxygenNotIncluded
{
    public class IncubationRate
    {
        public int BaseIncubationRate { get; }
        public int LullabiedIncubationRate { get; }

        public IncubationRate(int baseIncubationRate, int lullabiedIncubationRate)
        {
            BaseIncubationRate = baseIncubationRate;
            LullabiedIncubationRate = lullabiedIncubationRate;
        }
    }
}