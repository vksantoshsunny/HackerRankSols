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
    public static void minimumBribes(int[] arr)
    {
        int swapCount = 0;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] != i + 1)
            {
                if (((i - 1) >= 0) && arr[i - 1] == (i + 1))
                {
                    swapCount++;
                    swap(arr, i, i - 1);
                }
                else if ((i - 2) >= 0 && arr[i - 2] == (i + 1))
                {
                    swapCount += 2;
                    swap(arr, i - 2, i - 1);
                    swap(arr, i - 1, i);
                }
                else
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }
        }

        Console.WriteLine(swapCount);
    }

    static void swap(int[] arr, int a, int b)
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

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
            minimumBribes(q);
        }
    }
}
