using Tyuiu.FabritsiusAO.Sprint3.Task1.V17.Lib;

namespace Tyuiu.FabritsiusAO.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 0;
            int startValue = 1;
            int stopValue = 4;
            double wait = 1024;

            Assert.AreEqual(wait, ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}