using Tyuiu.BerezovskayaGO.Sprint4.Task4.V29.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint4.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                                             *");
            Console.WriteLine("* Задание #4                                                                               *");
            Console.WriteLine("* Вариант #29                                                                              *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с клавиатуры *");
            Console.WriteLine("* в диапазоне от 4 до 8. Найдите сумму четных элементов массива.                           *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            Console.WriteLine("********************************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {i},{j} элемент массива: ");
                    mtrx[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив:");
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

            Console.WriteLine("Сумма четных элементов = " + res);
            Console.ReadKey();
        }
    }
}
