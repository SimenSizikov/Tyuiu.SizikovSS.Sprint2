using Tyuiu.SizikovSS.Sprint2.Task6.V15.Lib;

namespace Tyuiu.SizikovSS.Sprint2.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                DataService ds = new();
                int k = 91;

                Assert.AreEqual("Понедельник", ds.FindDayName(k));
            }
        }
    }
}
