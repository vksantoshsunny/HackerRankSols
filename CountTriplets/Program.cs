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

    // Complete the countTriplets function below.
    static long countTriplets(List<long> arr, long r)
    {
        Dictionary<long, long> arrRightLookUp = new Dictionary<long, long>();
        Dictionary<long, long> arrLeftLookUp = new Dictionary<long, long>();
        long count = 0;

        foreach(var item in arr)
        {
            if(arrRightLookUp.ContainsKey(item))
                {

                arrRightLookUp[item]++;

            }
            else
            {
                arrRightLookUp.Add(item, 1);
            }
        }

        for(int i=0;i<arr.Count;i++)
        {
            long middleElement = arr[i];
            long leftCount = 0; long rightCount = 0;

            arrRightLookUp[middleElement] = arrRightLookUp[middleElement] - 1;

            if (arrLeftLookUp.ContainsKey(middleElement / r) && middleElement % r == 0)
            {
                leftCount = arrLeftLookUp[middleElement / r];
            }


            if (arrRightLookUp.ContainsKey(middleElement * r) )
            {
                rightCount = arrRightLookUp[middleElement * r];
            }

            count += leftCount * rightCount;

            if (arrLeftLookUp.ContainsKey(middleElement))
            {

                arrLeftLookUp[middleElement]++;

            }
            else
            {
                arrLeftLookUp.Add(middleElement, 1);
            }


        }

        

        return count;

    }

    static void Main(string[] args)
    {


        string[] nr = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nr[0]);

        long r = Convert.ToInt64(nr[1]);

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        long ans = countTriplets(arr, r);

    }
}
