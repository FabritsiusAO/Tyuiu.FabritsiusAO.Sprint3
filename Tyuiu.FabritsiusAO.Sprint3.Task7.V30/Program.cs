using Tyuiu.FabritsiusAO.Sprint3.Task7.V30.Lib;

class Program
{
    static void Main(string[] args)
    {
        var ds = new DataService();

        int startValue = -5;
        int stopValue = 5;

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] res; res = new double[len]; res = ds.GetMassFunction(startValue, stopValue);

        Console.Title = "Спринт # | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #                                                                *");
        Console.WriteLine("* Тема:                                                                   *");
        Console.WriteLine("* Задание #                                                               *");
        Console.WriteLine("* Вариант #                                                               *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Начало отрезка: " + startValue);
        Console.WriteLine("Конец отрезка: " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+----------+---------+");
        Console.WriteLine("|    X     |  f(x)   |");
        Console.WriteLine("+----------+---------+");
        for (int i = 0; i<=len-1; i++)
        {
            Console.WriteLine("|{0,5:d}     |  {1,5:f2} |", startValue, res[i]);
            startValue++;
        }
        Console.WriteLine("+---------+---------+");
        Console.ReadLine();
    }
}