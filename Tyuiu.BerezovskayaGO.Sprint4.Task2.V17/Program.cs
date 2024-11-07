using Tyuiu.BerezovskayaGO.Sprint4.Task2.V17.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint4.Task2.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();  
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                              *");
            Console.WriteLine("* Задание #2                                                                               *");
            Console.WriteLine("* Вариант #17                                                                              *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 9 элементов заполненный случайными в диапазоне    *");
            Console.WriteLine("* от 3 до 9 подсчитать произведение нечетных элементов массива.                            *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(3,9);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Сумма нечетных элементов = " + res);
            Console.ReadKey();
        }
    }
}
