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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        int val = 0;

        for (int i = q.Length - 1; i >= 0; i--)
        {
            if (q[i] != i + 1)
            {
                if ((i - 1) > 0 && q[i-1] == (i+1))
                {
                    val++;
                    swap(q,i,i-1);
                }
                else if ((i - 2) > 0 && q[i - 2] == (i + 1))
                {
                    val += 2;
                    swap(q, i - 2, i - 1);
                    swap(q, i - 1, i );
                }
                else
                {
                    Console.WriteLine("Too chaotic");
                }
            }
        }
        Console.WriteLine(val);
    }

    private static void swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
            minimumBribes(q);
        }
    }
}
