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
                0 => "Понедельник",
                1 => "Вторник",
                2 => "Среда",
                3 => "Четверг",
                4 => "Пятница",
                5 => "Суббота",
                6 => "Воскресенье",
                _ => throw new ArgumentException("Некорректный день года")
            };
        }
    }
}
