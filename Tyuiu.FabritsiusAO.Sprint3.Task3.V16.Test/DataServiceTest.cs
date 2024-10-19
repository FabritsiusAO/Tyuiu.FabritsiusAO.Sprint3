using Tyuiu.FabritsiusAO.Sprint3.Task3.V16.Lib;

namespace Tyuiu.FabritsiusAO.Sprint3.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "ccc";
            char item = 'c';
            int res = ds.GetCharCount(value,item);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}