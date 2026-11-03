using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TsarevMA.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if ((x >= -3 && x <= -2 && y >= 2 - x && y <= x * x) ||
                (x >= 0 && x <= 1 && y >= 0 && y <= x * x) ||
                (x >= 1 && x <= 2 && y >= 0 && y <= 2 - x))
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
