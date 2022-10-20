using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;

namespace SubarrayDivision
{
    internal class Program
    {
        static void Main()
        {
            List<int> s = new List<int>() { 2, 2, 1, 3, 2 };
            int d = 4;
            int m = 2;
            int result = 0;
            for (int i = 0; i < s.Count; i++)
            {

                int sum = 0;

                for (int j = i; j < i + m; j++)
                {
                    if (j == s.Count)
                    {
                        break;
                    }
                    sum += s[j];

                }
                if (sum == d)
                {
                    result++;
                }
            }
            Console.Write(result);
        }
    }
}
