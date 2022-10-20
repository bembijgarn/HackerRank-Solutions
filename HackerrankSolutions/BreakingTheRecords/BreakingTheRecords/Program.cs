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
    public static List<int> breakingRecords(List<int> scores)
    {
        int Score = 0;
        int Min = 0;
        int Max = 0;
        List<int> Sum = new List<int>() { 0, 0 };
        for (int i = 0; i < scores.Count; i++)
        {
            if (i == 0)
            {
                Score = scores[i];
                Min = scores[i];
                Max = scores[i];
            }
            if (i != 0 && scores[i] > Score && scores[i] > Max)
            {
                Score = scores[i];
                Max = scores[i];
                Sum[0]++;
            }
            else if (i != 0 && scores[i] > Score && scores[i] < Max)
            {
                Score = scores[i];
            }
            else if (i != 0 && scores[i] == Score)
            {
                continue;
            }
            else if (i != 0 && scores[i] < Score && scores[i] < Min)
            {
                Score = scores[i];
                Min = scores[i];
                Sum[1]++;
            }
            else if (i != 0 && scores[i] < Score && scores[i] > Min)
            {
                Score = scores[i];

            }
        }
        return Sum;
    }

}

