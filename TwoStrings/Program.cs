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

    // Complete the twoStrings function below.
    static string twoStrings(string s1, string s2)
    {

       var s1Array = s1.ToLower().ToCharArray();
        var s2Array = s2.ToLower().ToCharArray();

        Dictionary<char, int> s1ArrayLookup = new Dictionary<char, int>();
        Dictionary<char, int> s2ArrayLookup = new Dictionary<char, int>();


        foreach (var item in s1Array)
        {
           if(! s1ArrayLookup.ContainsKey(item))
            {
                s1ArrayLookup.Add(item, 1);
            }

        }

        foreach (var item in s2Array)
        {
            if (!s2ArrayLookup.ContainsKey(item))
            {
                s2ArrayLookup.Add(item, 1);
            }

        }


        if(s1ArrayLookup.Keys.Any(x => s2ArrayLookup.Keys.Contains(x)))
            {
            return "YES";
        }


        return "NO";


    }

    static void Main(string[] args)
    {
       

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = twoStrings(s1, s2);

            
        }


    }
}
