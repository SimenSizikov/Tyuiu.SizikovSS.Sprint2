using Tyuiu.SizikovSS.Sprint2.Task2.V24.Lib;

namespace Tyuiu.SizikovSS.Sprint2.Task2.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #2 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X (от 1 до 15):");
            int x, y;
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                if ((x > 15) || (x < 1)) Console.WriteLine("Введите значение от 1 до 15:");
            } while ((x > 15) || (x < 1));

            Console.WriteLine("Введите значение Y (от 1 до 15):");
            do
            {
                y = Convert.ToInt32(Console.ReadLine());
                if ((y > 15) || (y < 1)) Console.WriteLine("Введите значение от 1 до 15:");
            } while ((y > 15) || (y < 1));

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}