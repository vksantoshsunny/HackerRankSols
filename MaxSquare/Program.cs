using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using System.Xml.XPath;


class Result
{

    /*
     * Complete the 'largestMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int largestMatrix(List<List<int>> arr)
    {
        
        int sizeOfArray = arr.Count;
        int result = 0;

        var cache = arr;

        for (int i = 0; i < sizeOfArray; i++)
        {
            for (int j = 0; j < sizeOfArray; j++)
            {
                if (i == 0 || j == 0)
                {
                   //
                }
                else if(arr[i][j]>0)
                {
                    cache[i][j] = 1 + Math.Min(Math.Min(cache[i-1][j], cache[i - 1][j-1]), cache[i][j-1]);
                    if (cache[i][j] > result)
                    {
                        result = cache[i][j];
                    }
                }
            }
        }

        return result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int arrRows = Convert.ToInt32(Console.ReadLine().Trim());
        int arrColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < arrRows; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.largestMatrix(arr);

    }
}
