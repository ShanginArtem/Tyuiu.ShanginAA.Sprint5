using Tyuiu.ShanginAA.Sprint5.Task1.V25.Lib;

namespace Tyuiu.ShanginAA.Sprint5.Task1.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шангин А. А. | ИСП6-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Шангин Артём Александрович | ИСПб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [6, 15] сумму всех делителей                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int st = -5;
            int en = 5;

            Console.WriteLine("Старт шага: " + st);
            Console.WriteLine("Конец шага: " + en);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(st, en);
            Console.WriteLine("Файл:  " + res);
            Console.WriteLine("Создан! ");

            Console.ReadKey();


        }
    }
}