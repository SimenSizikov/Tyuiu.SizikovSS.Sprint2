using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SizikovSS.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            int res = (k + 1) % 7;

            switch (res)
            {
                case 0: return "Воскресенье";
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                default: return "Неверные данные";
            }
        }
    }
}
