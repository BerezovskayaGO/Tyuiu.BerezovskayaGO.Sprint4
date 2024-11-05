using Tyuiu.BerezovskayaGO.Sprint4.Task0.V12.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint4.Task0.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                              *");
            Console.WriteLine("* Задание #0                                                                               *");
            Console.WriteLine("* Вариант #12                                                                              *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими             *");
            Console.WriteLine("* значениями в диапазоне от 0 до 9 подсчитать произведение четных элементов массива.       *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("Произведение четных элементов = " + ds.GetMultEvenArrEl(numsArray));

            Console.ReadKey();
        }
    }
}