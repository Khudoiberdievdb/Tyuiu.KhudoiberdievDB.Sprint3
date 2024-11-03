using Tyuiu.KhudoiberdievDB.Sprint3.Task3.V15.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Худойбердиев Д. Б. | ИСПБ 24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #15                                                                  *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв m, находящихся *");
            Console.WriteLine("* на соседних позициях в строке: lrmmse mg sermmmrt                            *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            string str = "lrmmse mg sermmmrt";
            char chr = 'm';
            Console.WriteLine("Исходная строка: lrmmse mg sermmmrt");
            Console.WriteLine("Исходный символ: m");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Количество символов = " + ds.GetMinCharCount(str, chr));
            Console.ReadKey();
        }
    }
}
