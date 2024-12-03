using Tyuiu.SizikovSS.Sprint2.Task6.V15.Lib;

namespace Tyuiu.SizikovSS.Sprint2.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #2 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Условие: Дано целое число k (1 <= k <= 365). Определить, каким днем     *");
            Console.WriteLine("* недели (понедельником, вторником, …, субботой или воскресеньем)         *");
            Console.WriteLine("* является k-й день не високосного года, в котором 1 января понедельник.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int k;

            Console.WriteLine("Введите день (от 1 до 365):");
            do
            {
                k = Convert.ToInt32(Console.ReadLine());
                if ((k < 1) || (k > 365)) Console.WriteLine("Введите число от 1 до 365:");
            } while ((k < 1) || (k > 365));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.FindDayName(k));

            Console.ReadLine();
        }
    }
}
