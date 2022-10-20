using System;
using System.Linq;
namespace BuuBleSORT
{
    internal class Program
    {
        static void Main()
        {
            bool swapped = false;
            int[] arr = { 18, 29, 18, 37, 3, 41, 12, 13, 22, 5, 35, 27, 10 };
            Console.WriteLine("BEFORE");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            do
            {
                swapped = false;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        swapped = true;
                    }
                   
                }

            } while (swapped);
            Console.WriteLine("AFTER");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
