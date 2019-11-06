using System.IO;
using System;

class Solution
{

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        var remainder = n%s.Length;
        var quotient = n / s.Length;
        var substring = s.Substring(0,(int) remainder);


        int countinString = 0;
        int stringIndex = 0;
        while (stringIndex < s.Length)
        {
            if (s[stringIndex] == 'a')
                countinString++;
            stringIndex++;
        }

        int countinSubString = 0;
        int subStringIndex = 0;
        while (subStringIndex < substring.Length)
        {
            if (substring[subStringIndex] == 'a')
                countinSubString++;
            subStringIndex++;
        }


        return (countinString * quotient + countinSubString);



    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
