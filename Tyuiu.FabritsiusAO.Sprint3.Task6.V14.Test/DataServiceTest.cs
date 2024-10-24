using Tyuiu.FabritsiusAO.Sprint3.Task6.V14.Lib;

namespace Tyuiu.FabritsiusAO.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            int startValue = 15; int stopValue = 16;
            int wait = 3;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}