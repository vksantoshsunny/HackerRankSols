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

class Solution
{

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {

        int seaLevel = 0;
        int count = 0;
        var steps = s.ToCharArray();

        foreach (var step in steps)
        {
            bool isBelowSealevel = false;
            if (seaLevel < 0)
            {
                isBelowSealevel = true;
            }

            if (step == 'U')
            {
                seaLevel++;
            }
            else
            {
                seaLevel--;
            }

            if (seaLevel == 0 && isBelowSealevel)
            {
                count++;
            }
            
        }

        return count;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

       /* textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();*/
    }
}
