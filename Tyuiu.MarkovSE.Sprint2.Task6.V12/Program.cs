using Tyuiu.MarkovSE.Sprint2.Task6.V12.Lib;
namespace Tyuiu.MarkovSE.Sprint2.Task6.V12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Марков С. Е. | ИСП6-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Марков С. Е.  | ИСПб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* С начала 1990 года по некоторый день прошло n месяцев и 2 дня.          *");
            Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня.         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int g, m, n;

            Console.WriteLine("Введите год G:");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц M:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день N:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var s = ds.FindDateOfPreviousDay(g, m, n);
            Console.WriteLine("Вчера было " + s);

            Console.ReadKey();
        }
    }
}