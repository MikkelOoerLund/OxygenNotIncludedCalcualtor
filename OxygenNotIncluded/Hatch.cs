namespace OxygenNotIncluded
{
    public class Hatch
    {
        public int MaxAge { get; }

        public Meat Drop { get; }
        public AgeInfo AgeInfo { get; }

        public WildnessRate WildnessRate { get; }
        public IncubationRate IncubationRate { get; }
        public ReproductionRate ReproductionRate { get; }


        public Hatch(int maxAge, IncubationRate incubationRate, ReproductionRate reproductionRate, Meat drop, WildnessRate wildnessRate, AgeInfo ageInfo)
        {
            Drop = drop;
            MaxAge = maxAge;
            AgeInfo = ageInfo;
            WildnessRate = wildnessRate;
            IncubationRate = incubationRate;
            ReproductionRate = reproductionRate;
        }
    }
}