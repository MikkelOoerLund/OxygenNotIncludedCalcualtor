namespace OxygenNotIncluded
{
    public class AgeInfo
    {
        public int MaxAge { get; }
        public int CurrentAge { get; }

        public AgeInfo(int currentAge, int maxAge)
        {
            MaxAge = maxAge;
            CurrentAge = currentAge;
        }
    }
}