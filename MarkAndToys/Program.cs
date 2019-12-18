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

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k)
    {
        int n = prices.Length;
        int sum = 0;
        int count = 0;
        for(int i=0;i< n; i++)
        {
            for(int j = i+1; j < n; j++)
            {
                if(prices[i] > prices[j])
                {
                    int swap = prices[j];
                    prices[j] = prices[i];
                    prices[i] = swap;
                }
            }
            if(prices[i] + sum <= k)
            {
                sum = prices[i] + sum;
                count++;
            }
            else
            {
                break;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
        ;
        int result = maximumToys(prices, k);

       /* textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();*/
    }
}
