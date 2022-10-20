using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        List<int> app = new List<int>();
        List<int> orr = new List<int>();
        int appl = 0;
        int orn = 0;
        for (int i = 0; i < apples.Count; i++)
        {
            if (a + apples[i] >= s && a + apples[i] <= t)
            {
                app.Add(apples[i]);
            }
        }
        for (int j = 0; j < oranges.Count; j++)
        {
            if (b + oranges[j] >= s && b + oranges[j] <= t)
            {
                orr.Add(oranges[j]);
            }
        }
        for (int i = 0; i < app.Count; i++)
        {
            appl++;
        }
        for (int j = 0; j < orr.Count; j++)
        {
            orn++;
        }
        Console.WriteLine(appl);
        Console.WriteLine(orn);
    }

}

