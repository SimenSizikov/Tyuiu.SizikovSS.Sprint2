using Tyuiu.SizikovSS.Sprint2.Task5.V12.Lib;

namespace Tyuiu.SizikovSS.Sprint2.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 1, m = 12, g = 2024;

            Assert.AreEqual("30.11.2024", ds.FindDateOfPreviousDay(g, m, n));
        }
    }
}
