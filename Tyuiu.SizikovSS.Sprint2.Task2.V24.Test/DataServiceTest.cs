using Tyuiu.SizikovSS.Sprint2.Task2.V24.Lib;

namespace Tyuiu.SizikovSS.Sprint2.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new();
            int a = 7, b = 8;
            bool res;
            res = ds.CheckDotInShadedArea(a, b);

            Assert.AreEqual(true, res);
        }
    }
}
