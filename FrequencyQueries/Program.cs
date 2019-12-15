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

    // Complete the freqQuery function below.
    static List<int> freqQuery(List<List<int>> queries)
    {

        List<int> returnArray = new List<int>();
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        Dictionary<int, int> frequency = new Dictionary<int, int>();


        foreach (var query in queries)
        {
            var command = query.ElementAt(0);
            var element = query.ElementAt(1);
            if (command == 1)
            {
                if (!dictionary.ContainsKey(element))
                {
                    dictionary.Add(element, 0);

                }

                if (frequency.ContainsKey(dictionary[element]))
                {
                    frequency[dictionary[element]]--;
                }

                dictionary[element]++;

                if (!frequency.ContainsKey(dictionary[element]))
                {
                    frequency.Add(dictionary[element], 0);
                }

                frequency[dictionary[element]]++;

            }
            if (command == 2)
            {
                if (dictionary.ContainsKey(element) && dictionary[element] > 0)
                {
                    frequency[dictionary[element]]--;
                    dictionary[element]--;
                    if (dictionary[element] > 0)
                    {
                        frequency[dictionary[element]]++;
                    }
  
                }
  
            }
            if (command == 3)
            {
                if(frequency.ContainsKey(element) && frequency[element] > 0)
                {
                    returnArray.Add(1);
                }
                else
                {
                    returnArray.Add(0);
                }
            }
        }



        return returnArray;


    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> ans = freqQuery(queries);

        /*textWriter.WriteLine(String.Join("\n", ans));

        textWriter.Flush();
        textWriter.Close();*/
    }
}
