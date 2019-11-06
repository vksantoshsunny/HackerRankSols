using System.IO;
using System;

class Solution
{

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        int count = 0;
        int i = 0;
        while (i < c.Length - 1)
        {
            if (i+2 < c.Length && c[i + 2] != 1)
            {
                count++;
                i = i + 2;
                continue;
            }

            count++;
            i++;
        }

        return count;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
        int result = jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
