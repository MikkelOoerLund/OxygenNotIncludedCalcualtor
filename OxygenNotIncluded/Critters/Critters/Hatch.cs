namespace OxygenNotIncluded
{




    public class Hatch
    {
        public AgeInfo AgeInfo { get; }
        public DietInfo DietInfo { get; }
        public DropInfo DropInfo { get; }

        public WildnessRate WildnessRate { get; }
        public IncubationRate IncubationRate { get; }
        public ReproductionRate ReproductionRate { get; }

        public Hatch(AgeInfo ageInfo, DietInfo dietInfo, DropInfo dropInfo, WildnessRate wildnessRate, IncubationRate incubationRate, ReproductionRate reproductionRate)
        {
            AgeInfo = ageInfo;
            DietInfo = dietInfo;
            DropInfo = dropInfo;
            WildnessRate = wildnessRate;
            IncubationRate = incubationRate;
            ReproductionRate = reproductionRate;
        }
    }
}