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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        Dictionary<int, int> hourGlassValues = new Dictionary<int, int>();
        int key = 1;
        for(int row = 1; row < arr.Length - 1; row++)
        {
            for (int col = 1; col < arr.Length - 1; col++)
            {

                var value = arr[row][col] + arr[row-1][col-1] + arr[row-1][col] + arr[row-1][col+1] + arr[row+1][col-1] + arr[row+1][col] + arr[row+1][col+1]; 
                hourGlassValues.Add(key, value);
                key++;
            }
        }

        return hourGlassValues.Values.Max();
    }



    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
