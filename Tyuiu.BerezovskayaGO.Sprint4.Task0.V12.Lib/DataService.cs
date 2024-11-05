﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BerezovskayaGO.Sprint4.Task0.V12.Lib
{
    public class DataService : ISprint4Task0V12
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int multSeries = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    multSeries = multSeries * array[i];
                }
            }
            return multSeries;
        }
    }
}