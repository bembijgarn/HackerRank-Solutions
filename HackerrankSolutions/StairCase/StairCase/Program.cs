using System;
using System.Linq;

namespace StairCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7; //N = ?
            for (int x = 0; x < n; x++)
            {
                for (int y = n - 1; y >= 0; y--)
                {
                    if (x >= y)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
