using Tyuiu.SizikovSS.Sprint2.Task4.V19.Lib;

namespace Tyuiu.SizikovSS.Sprint2.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            double x = 5, y = 7;

            Assert.AreEqual(0.568, ds.Calculate(x, y));
        }
    }
}
