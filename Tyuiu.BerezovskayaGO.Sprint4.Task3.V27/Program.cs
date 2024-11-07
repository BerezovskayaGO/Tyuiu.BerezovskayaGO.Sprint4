using Tyuiu.BerezovskayaGO.Sprint4.Task3.V27.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint4.Task3.V27
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
            Console.WriteLine("* Задание #3                                                                               *");
            Console.WriteLine("* Вариант #27                                                                              *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими            *");
            Console.WriteLine("* значениями в диапазоне от 3 до 7. Подсчитайте количество четных элементов во всем масc.  *");
            Console.WriteLine("*                                                                                          *");

            int[,] mtrx = new int[5,5] { { 4, 3, 5, 5, 3 },
                                          { 6, 7, 4, 4, 3 },
                                          { 3, 3, 7, 3, 6 },
                                          { 3, 4, 3, 7, 7 },
                                          { 3, 5, 6, 3, 6 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            int res = ds.Calculate(mtrx);

            Console.WriteLine("Количество четных элементов = " + res);
            Console.ReadKey();
        }
    }
}
