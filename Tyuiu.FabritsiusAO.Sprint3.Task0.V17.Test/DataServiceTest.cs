using Tyuiu.FabritsiusAO.Sprint3.Task0.V17.Lib;

namespace Tyuiu.FabritsiusAO.Sprint3.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;
            double wait = -0.708723873227953;

            Assert.AreEqual(wait, ds.GetSumSeries(startValue, stopValue));
        }
    }
}