namespace OxygenNotIncluded
{
    public class IncubationRate
    {
        public int Base { get; }
        public int Lullabied { get; }

        public IncubationRate(int baseRate, int lullabiedRate)
        {
            Base = baseRate;
            Lullabied = lullabiedRate;
        }
    }
}