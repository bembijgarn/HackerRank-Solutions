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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {


        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] < 38)
            {

            }
            else
            {
                var check = grades[i] % 5;
                if (check > 2)
                {
                    grades[i] = grades[i] + 5 - check;
                }
            }
        }

        return grades;
    }

}

