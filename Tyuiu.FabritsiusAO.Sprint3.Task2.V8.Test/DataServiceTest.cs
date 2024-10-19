using Tyuiu.FabritsiusAO.Sprint3.Task2.V8.Lib;

namespace Tyuiu.FabritsiusAO.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 16;
            int stopValue = 15;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 0.607;
            Assert.AreEqual(wait, res);
        }
    }
}