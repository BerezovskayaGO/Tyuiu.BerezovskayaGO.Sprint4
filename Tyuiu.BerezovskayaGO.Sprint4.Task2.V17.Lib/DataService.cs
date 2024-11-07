using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BerezovskayaGO.Sprint4.Task2.V17.Lib
{
    public class DataService : ISprint4Task2V17
    {
        public int Calculate(int[] array)
        {
            int multSeries = 1;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    multSeries = multSeries * array[i];
                }
            }
            return multSeries;
        }
    }
}
