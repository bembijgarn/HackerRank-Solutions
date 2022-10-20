using System;

namespace DiagonalDifference
{
    internal class Program
    {
        static void Main()
        {
            int sum1 = 0;
            int sum2 = 0;
            int length = arr[0].Count;
            for (int i = 0; i < length; i++)
            {
                sum1 += arr[i][i + 0];
                sum2 += arr[i][length - i - 1];
            }
        }
    }
}
