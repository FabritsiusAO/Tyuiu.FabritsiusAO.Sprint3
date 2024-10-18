using Tyuiu.FabritsiusAO.Sprint3.Task1.V17.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int value = 1;
        int startValue = 1;
        int stopValue = 4;

        Console.Title = "Спринт #3 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла while                                              *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет              *");
        Console.WriteLine("* произведение ряда по формуле, при х=1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Значение x: " + value);
        Console.WriteLine("Начальное значение i: " + startValue);
        Console.WriteLine("Конечное значение i: " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));

    }
}