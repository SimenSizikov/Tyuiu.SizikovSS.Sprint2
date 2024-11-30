using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SizikovSS.Sprint2.Task1.V20.Lib
{
    public class DataService : ISprint2Task1V20
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | false;
            res[1] = true & (a >= c);
            res[2] = (b > c) || (d > a);
            res[3] = (a != b) && (d <= c);
            res[4] = !(a == d);
            res[5] = (a >= c) ^ (b > d); // если разные - true

            return res;
        }
    }

}
