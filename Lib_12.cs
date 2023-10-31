using System;

namespace Lib_12
{
    public class Calculation
    {
        public static int SumNumbersGreaterThanFifteen(int[] array)
        {
            int sum = 0;

            foreach (int number in array)
            {
                if (number > 15)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}