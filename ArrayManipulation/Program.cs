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

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries)
    {
        long[] zeroIndArray = new long[n];

        for (long i = 0; i < queries.GetLength(0); i++)
        {
            int start = queries[i][0] - 1;
            int end = queries[i][1];
            int sum = queries[i][2];

            zeroIndArray[start] += sum;
            if (queries[i][1] != n)
            {
                zeroIndArray[end] -= sum;
            }
        }

        long max = 0;
        long val = 0;

        foreach (long j in zeroIndArray)
        {
            val += j;
            if (val > max)
            {
                max = val;
            }
        }

        return max;


    }

    static void Main(string[] args)
    {
        

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        
    }
}
