using Tyuiu.BerezovskayaGO.Sprint4.Task6.V25.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint4.Task6.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                *");
            Console.WriteLine("* Тема: Класс Array                                                                        *");
            Console.WriteLine("* Задание #6                                                                               *");
            Console.WriteLine("* Вариант #25                                                                              *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Дан строковый массив данных. Используя класс Array подсчитайте количество элементов,     *");
            Console.WriteLine("* длина которых больше 6.                                                                  *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            var x = new string[] { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= x.Length - 1; i++)
            {
                Console.WriteLine(x[i]);
            }

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            
            int nums = ds.Calculate(x);
            Console.WriteLine("Количество элементов, длина которых больше 6 = " + nums);

            Console.ReadKey();

            
        }
    }
}
