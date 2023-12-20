using Newtonsoft.Json;
using OxygenNotIncluded;
using System.Diagnostics;

namespace OxygenNotIncludedTest
{


    [TestClass]
    public class HatchTester
    {


        [TestMethod]
        public void TestFromJsonToHatch()
        {
            var jsonTextFilePath = "C:\\Repository\\OxygenNotIncludedCalcualtor\\OxygenNotIncluded\\TextFiles\\Json\\HatchJson.txt";

            var jsonText = File.ReadAllText(jsonTextFilePath);

            var hatch = JsonConvert.DeserializeObject<Hatch>(jsonText);

            Assert.IsNotNull(hatch);

            var serializedJson = JsonConvert.SerializeObject(hatch, Formatting.Indented);
            Console.WriteLine(serializedJson);
        }



    }
}