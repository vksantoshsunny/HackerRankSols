using System.IO;
using System;

class Solution
{

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        int moves = d % a.Length;
        int[] newArray = new int[a.Length];
        for (int k = 0; k < a.Length; k++)
        {
            if (moves == a.Length)
            {
                moves = 0;
            }
            newArray[k] = a[moves];
            moves++;
        }

        return newArray;

    }

    static void Main(string[] args)
    {

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

        int[] result = rotLeft(a, d);


    }
}
