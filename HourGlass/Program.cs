using System;

class Solution
{

    // Complete the hourglassSum function below.
   /* static int hourglassSum(int[][] arr)
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {

            }
        }


    }*/

    static void Main(string[] args)
    {


        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        //int result = hourglassSum(arr);

    }
}
