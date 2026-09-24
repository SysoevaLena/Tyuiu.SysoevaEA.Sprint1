using Tyuiu.SysoevaEA.Sprint1.Task3.V16.Lib;

namespace Tyuiu.SysoevaEA.Sprint1.Task3.V16
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Сысоева Елена Андреевна | ИБКСб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя два корня        *");
            Console.WriteLine("* уравнения (два вещественных числа), вычисляет и печатает коэффициент    *");
            Console.WriteLine("* приведённого квадратного уравнения, округлив до трёх знаков после       *");  
            Console.WriteLine("* запятой.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            double y;

            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.Write("* Коэффициент приведенного квадратного уравнения = ");
            Console.WriteLine(ds.CoeffOfQuadraticEquation(x, y));

            Console.ReadKey();
        }
    }
}
