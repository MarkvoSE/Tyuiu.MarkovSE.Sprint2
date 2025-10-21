using Tyuiu.MarkovSE.Sprint2.Task3.V16.Lib;

namespace Tyuiu.MarkovSE.Sprint2.Task3.V16
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                DataService ds = new DataService();
                Console.Title = "Спринт #2 | Выполнил: Марков С. Е. | ИсПБ-24-2";
                Console.WriteLine("************************************************************************");
                Console.WriteLine("* Спринт #2                                                            *");
                Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                   *");
                Console.WriteLine("* Задание #3                                                           *");
                Console.WriteLine("* Вариант #16                                                          *");
                Console.WriteLine("* Выполнил: Марков С.Е. | ИсПБ-24-2                                    *");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                             *");
                Console.WriteLine("* Написать программу на, которая запрашивает целые значения с          *");
                Console.WriteLine("* клавиатуры и вычисляет находится ли точка с координатами X,Y в       *");
                Console.WriteLine("* заштрихованной области.                                              *");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
                Console.WriteLine("************************************************************************");

                

                Console.WriteLine("Введите значение х:");
                double x = Convert.ToDouble(Console.ReadLine());
                double res = ds.Calculate(x);

                Console.WriteLine("********************************************************************");
                Console.WriteLine("РЕЗУЛЬТАТ");
                Console.WriteLine("********************************************************************");

                Console.WriteLine("Значение функции = " + res);

                Console.ReadKey();
            }
        
    }
}