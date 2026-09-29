using Tyuiu.SysoevaEA.Sprint1.Task7.V27.Lib;

namespace Tyuiu.SysoevaEA.Sprint1.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Сысоева Е. А. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Сысоева Елена Андреевна | ИБКСб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*            2         2                                                  *");
            Console.WriteLine("*      cos(x)  + sin(y)     x * y - 12                                    *");
            Console.WriteLine("* z = ------------------ - -------------                                  *");
            Console.WriteLine("*         sin(y) + 1        15 + cos(x)                                   *");

            double x, y;

            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("z = " + ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
