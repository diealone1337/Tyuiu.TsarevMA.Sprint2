using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TsarevMA.Sprint2.Task2.V20.Lib
{
    public class DataService : ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3 && x <= 5 && y >= 3 && y <= 6) ||
                (x >= 3 && x <= 5 && y == 11) ||
                (x >= 6 && x <= 8 && y >= 5 && y <= 11) ||
                (x == 9 && (y == 3 || (y >= 6 && y <= 12))) ||
                (x >= 10 && x <= 11 && y >= 8 && y <= 12) ||
                (x == 13 && y >= 6 && y <= 7))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
