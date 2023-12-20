namespace OxygenNotIncluded
{
    public class ReproductionRate
    {
        public int WildReproductionRate { get; }
        public int GroomedReproductionRate { get; }

        public ReproductionRate(int wildReproductionRate, int groomedReproductionRate)
        {
            WildReproductionRate = wildReproductionRate;
            GroomedReproductionRate = groomedReproductionRate;
        }
    }
}