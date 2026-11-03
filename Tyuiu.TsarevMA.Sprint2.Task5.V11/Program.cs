using Tyuiu.TsarevMA.Sprint2.Task5.V11.Lib;
namespace Tyuiu.TsarevMA.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя числами: g, m, n.             *");
            Console.WriteLine("* По заданным g, n и m определить дату следующего дня (год не високосный).*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год (g): ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Дата следующего дня: " + res);

            Console.ReadKey();
        }
    }
}