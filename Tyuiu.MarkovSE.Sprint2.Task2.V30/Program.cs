using Tyuiu.MarkovSE.Sprint2.Task2.V30.Lib;
namespace Tyuiu.MarkovSE.Sprint2.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Марков С. Е. | ИсПБ-24-2";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #2                                                            *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                   *");
            Console.WriteLine("* Задание #2                                                           *");
            Console.WriteLine("* Вариант #30                                                          *");
            Console.WriteLine("* Выполнил: Марков С.Е. | ИсПБ-24-2                                    *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с          *");
            Console.WriteLine("* клавиатуры и вычисляет находится ли точка с координатами X,Y в       *");
            Console.WriteLine("* заштрихованной области.                                              *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            bool result = new DataService().CheckDotInShadedArea(x, y);
            if (result)
                Console.WriteLine($"Точка с координатами ({x}, {y}) находится в заштрихованной области.");
            else
                Console.WriteLine($"Точка с координатами {x}, {y} НЕ находится в заштрихованной области.");

            Console.ReadLine();
        }
    }
}