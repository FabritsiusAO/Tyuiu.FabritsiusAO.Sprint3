using Tyuiu.FabritsiusAO.Sprint3.Task7.V30.Lib;

namespace Tyuiu.FabritsiusAO.Sprint3.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            int startValue = 1; int stopValue = 3;
            int len = stopValue - startValue + 1; double[] waitres; waitres = new double[len];

            waitres[0] = 6.64;
            waitres[1] = 10.3;
            waitres[2] = 16.17;

            double[] res; res = new double[len]; res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, waitres);
        }
    }
}