using OxygenNotIncluded;

namespace OxygenNotIncludedTest
{

    public class HatchEgg
    {
        public int EggAge { get; set; }
    }

    public class Hatchling
    {
        public int Age { get; set; }
    }

    public class Hatch
    {
        public int Age { get; set; }
    }

    public class Incubator
    {
        public HatchEgg? HatchEgg { get; set; }
        public Hatchling? Hatchling { get; set; }

        public bool HasEntity
        {
            get => HatchEgg != null || Hatchling != null;
        }

    }

    public class Cycle
    {
        public int ProducedCalories { get; set; }
    }

    [TestClass]
    public class HatchCalculator
    {
        // Assumes hatches are tamed and fed

        [TestMethod]
        public void CalculateCaloriesProductionOverCycles()
        {
            var initialHatchAge = 50;
            var initialHatchesCount = 1;
            var initialIncubatorCount = 4;

            var incubators = CreateIncubators(initialIncubatorCount);
            var ranchedHatches = CreateHatchesWithAge(initialHatchesCount, initialHatchAge);

            var maxHatchAge = 100;

            var amountOfCyclesToApproximate = 100;
            var hatchEggsInWater = new List<HatchEgg>();

            for (int cycleIndex = 0; cycleIndex < amountOfCyclesToApproximate; cycleIndex++)
            {
                var deadHatches = new List<Hatch>();

                foreach (var hatch in ranchedHatches)
                {
                    if (hatch.Age >= maxHatchAge)
                    {
                        deadHatches.Add(hatch);
                        continue;
                    }




                }

            }


        }



    

        private List<Hatch> CreateHatchesWithAge(int amount, int age)
        {
            var hatches = new List<Hatch>();

            for (int index = 0; index < amount; index++)
            {
                hatches.Add(new Hatch()
                {
                    Age = age,
                });
            }

            return hatches;
        }


        private List<Incubator> CreateIncubators(int amount)
        {
            var incubators = new List<Incubator>();

            for (int index = 0; index < amount; index++)
            {
                incubators.Add(new Incubator());
            }

            return incubators;
        }


    }
}