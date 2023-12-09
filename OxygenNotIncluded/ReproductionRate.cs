namespace OxygenNotIncluded
{
    public class ReproductionRate
    {
        public int Wild { get; }
        public int Groomed { get; }

        public ReproductionRate(int wildRate, int groomedRate)
        {
            Wild = wildRate;
            Groomed = groomedRate;
        }
    }
}