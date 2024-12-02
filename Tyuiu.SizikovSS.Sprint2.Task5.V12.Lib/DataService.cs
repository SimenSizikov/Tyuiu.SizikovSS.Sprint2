using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SizikovSS.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int pday = n - 1;
            if (pday == 0)
            {
                m--;
                if (m == 0)
                {
                    m = 12;
                    g--;
                }
                
                switch (m)
                {
                    case 1:case 5: case 7: case 8: case 10: case 12:
                        pday = 31;
                        break;
                    case 4: case 6: case 9: case 11:
                        pday = 30;
                        break;
                    case 2: 
                        if ( (g%400==0) || ((g%4==0) && (g%100!=0) ))
                        {
                            pday = 29;
                            break;
                        }
                        else
                        {
                            pday = 28;
                            break;
                        }
                    default:
                        throw new ArgumentException("Неверно введены данные");

                }
                
            }
            return ($"{pday:D2}.{m:D2}.{g}");

        }
    }
}
