using Tyuiu.FabritsiusAO.Sprint3.Task3.V16.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        string value = "ice nice ice creamcc";
        char item = 'c';
        Console.Title = "Спринт #3 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл foreach подсчитать количество букв “c” в строке          *");
        Console.WriteLine("* ice nice ice creamcc                                                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Строка: " + value);
        Console.WriteLine("Искомая буква: " + item);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetCharCount(value, item));
    }
}