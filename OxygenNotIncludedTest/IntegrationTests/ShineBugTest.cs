using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxygenNotIncludedTest
{

   public class ShineBug
   {
        private const int INITIAL_CALORIES = 288;
        private const int BASE_CALORIE_CONSUMPTION_PER_CYCLE = 40;

        private int _calories;
        private int _motabolisimRate;

        public ShineBug()
        {
            _calories = INITIAL_CALORIES;
        }

        public void ConsumeKcalories()
        {
            var caloriesToConsume = BASE_CALORIE_CONSUMPTION_PER_CYCLE / (100 - 90);
            _calories = _calories - caloriesToConsume;
        }


        public int Calories => _calories;
        public int Motabolisim { get => _motabolisimRate; set => _motabolisimRate = value; }
    }



    [TestClass]
    public class ShineBugTest
    {

        [TestMethod]
        public void Calculate()
        {
            var shineBug = new ShineBug();
            shineBug.Motabolisim = 90;

            shineBug.ConsumeKcalories();
            shineBug.ConsumeKcalories();
            shineBug.ConsumeKcalories();
            shineBug.ConsumeKcalories();
            shineBug.ConsumeKcalories();

            Console.WriteLine(shineBug.Calories);
        }
    }
}
