using Tyuiu.SizikovSS.Sprint2.Task0.V23.Lib;

namespace Tyuiu.SizikovSS.Sprint2.Task0.V23.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int x = 3105, y = 77;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        bool[] wait = new bool[6] { false, true, true, true, true, false };
        CollectionAssert.AreEqual(wait, res);
    }
}

