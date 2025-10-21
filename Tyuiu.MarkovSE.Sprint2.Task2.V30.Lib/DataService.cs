using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MarkovSE.Sprint2.Task2.V30.Lib
{
    public class DataService : ISprint2Task2V30
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            switch (x)
            {
                default: return false;
                case 2:
                    return 4 <= y && y <= 6;
                case 3:
                case 4:
                case 5:
                case 11:
                case 12:
                    return (3 <= y && y <= 7) || y == 11;
                case 6:
                    return 5 <= y && y <= 11;
                case 7:
                case 8:
                    return (5 <= y && y <= 7) || y == 11 || y == 12;
                case 9:
                case 10:
                    return (3 <= y && y <= 7) || y == 11 || y == 12;
                case 13:
                    return y == 6 || y == 7;
            }
        }
    }
}