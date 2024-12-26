using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MarkovSE.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            startYear = 1990;
            string month;
            if (n > 12)
            {
                n %= 12;
            }
            switch (n)
            {
                case 0:
                    month = "январь";
                    break;
                case 1:
                    month = "февраль";
                    break;
                case 2:
                    month = "март";
                    break;
                case 3:
                    month = "аперель";
                    break;
                case 4:
                    month = "май";
                    break;
                case 5:
                    month = "июнь";
                    break;
                case 6:
                    month = "июль";
                    break;
                case 7:
                    month = "август";
                    break;
                case 8:
                    month = "сентябрь";
                    break;
                case 9:
                    month = "октябрь";
                    break;
                case 10:
                    month = "ноябрь";
                    break;
                case 11:
                    month = "декабрь";
                    break;
                default:
                    month = "Неверное число";
                    break;
            }
            return month;
        }
    }
}