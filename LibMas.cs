using System;

namespace LibMas
{
    public class ArrayUtils
    {
        public static int[] FillArray(int n)
        {
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 30); // Заполняем массив случайными числами от 1 до 29.
            }

            return array;
        }
    }
}
