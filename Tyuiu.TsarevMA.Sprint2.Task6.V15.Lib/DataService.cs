using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TsarevMA.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            int day = (k - 1) % 7;

            return day switch
            {
                0 => "понедельник",
                1 => "вторник",
                2 => "среда",
                3 => "четверг",
                4 => "пятница",
                5 => "суббота",
                6 => "воскресенье",
                _ => throw new ArgumentException("Некорректный день года")
            };
        }
    }
}
