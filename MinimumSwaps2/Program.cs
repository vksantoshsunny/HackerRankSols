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

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            var position = i + 1;
            var currentValue = arr[i];
            if (currentValue == position)
            {
                continue;
            }

            do
            {
                swap(arr, i, arr[i] - 1);
                count++;
            } while (arr[i] != i + 1);

        }

        return count;

    }

    static void swap(int[] array, int pos1, int pos2)
    {
        int temp = array[pos1]; // Copy the first position's element
        array[pos1] = array[pos2]; // Assign to the second element
        array[pos2] = temp;
    }

    static void Main(string[] args)
    {


        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);


    }
}