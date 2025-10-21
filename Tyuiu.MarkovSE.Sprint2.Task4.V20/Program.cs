using Tyuiu.MarkovSE.Sprint2.Task4.V20.Lib;
namespace Tyuiu.MarkovSE.Sprint2.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x;
            double y;

            Console.Title = "Спринт #2 | Выполнил: Марков С. Е. | ИСП6-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Марков С. Е. | ИСПб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
            Console.WriteLine("* переменных х,у с клавиатуры                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();


        }
    }
}