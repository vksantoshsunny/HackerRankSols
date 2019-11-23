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

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {
        Dictionary<string, int> magazineLookUp = new Dictionary<string, int>();

        
        foreach(var mag in magazine)
        {
            if (magazineLookUp.ContainsKey(mag))
            {
                magazineLookUp[mag]++;
            }
            else
            {
                magazineLookUp.Add(mag, 1);
            }
        }

        Dictionary<string, int> noteLookUp = new Dictionary<string, int>();

        foreach (var noteItem in note)
        {
            if (noteLookUp.ContainsKey(noteItem))
            {
                noteLookUp[noteItem]++;
            }
            else
            {
                noteLookUp.Add(noteItem, 1);
            }
        }

        if(magazine.Length < note.Length)
        {
            Console.WriteLine("No");
            return;
        }


        foreach(var key in noteLookUp.Keys)
        {
            if(magazineLookUp.ContainsKey(key) && magazineLookUp[key] >= noteLookUp[key])
            {
                continue;
            }
            Console.WriteLine("No");
            return;
        }

        Console.WriteLine("Yes");

    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
