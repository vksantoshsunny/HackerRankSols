using System.Collections.Generic;
using System.IO;
using System;

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        Dictionary<int,int> cache = new Dictionary<int, int>();
        int totalPairs = 0;

        for (int i = 0; i < ar.Length; i++)
        {
            if (cache.ContainsKey(ar[i]))
            {
                cache[ar[i]] = cache[ar[i]] + 1;
            }
            else
            {
                cache.Add(ar[i],1);
            }
        }

        foreach (var keyValuePair in cache)
        {
            totalPairs = (keyValuePair.Value % 2) == 0 ? ((keyValuePair.Value / 2) + totalPairs) 
                                                        : (((keyValuePair.Value - 1) / 2) + totalPairs);
        }

        return totalPairs;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
