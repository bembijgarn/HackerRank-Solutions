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
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        var n = candles.OrderByDescending(x => x).Take(1);
        int number = 0;
        foreach (var z in n)
        {
            number += z;
        }
        List<int> can = new List<int>();
        for (int i = 0; i < candles.Count; i++)
        {
            if (candles[i] == number)
            {
                can.Add(candles[i]);
            }
        }
        int sum = 0;
        var tall = from s in can group s by s into y select y;
        foreach (var item in tall)
        {
            sum += item.Count();
        }
        return sum;
    }


}

