using System;
using System.Linq;


namespace LongestPossibleSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        public int solution(string[] words)
        {
          var joinedstring =  String.Join("", words);

         // find distinct characters

          var distinctChars = joinedstring.ToCharArray(0, joinedstring.Length).Distinct();

          int longestSubstring = 1;

          foreach (var letter in distinctChars)
          {
              int longestSuffix = 0;
              foreach (var word in words.Where(x => x.EndsWith(letter.ToString()) && x.StartsWith(letter.ToString()) == false))
              {
                  var wordSuffix = word;
                  int suffix = 0;
                  do
                  {
                      suffix = suffix + 1;
                      wordSuffix = wordSuffix.Substring(wordSuffix.Length - 1);
                  } while (wordSuffix.EndsWith(letter.ToString()));

                if(suffix > longestSuffix)
                longestSuffix = suffix;
              }



              int longestAllLetters = 0;

              if (words.Any(x => x.StartsWith(letter.ToString()) && x.EndsWith(letter.ToString())))
              {
                longestAllLetters =  words.Where(x => x.StartsWith(letter.ToString()) && x.EndsWith(letter.ToString())).Max(y => y.Length);
              }

              int longestPrefix = 0;

              foreach (var word in words.Where(x => x.StartsWith(letter.ToString()) && x.EndsWith(letter.ToString()) == false))
              {
                  var wordPrefix = word;
                  int prefix = 0;
                  do
                  {
                      prefix = prefix + 1;
                      wordPrefix = wordPrefix.Substring(1);
                  } while (wordPrefix.StartsWith(letter.ToString()));


                  if (prefix > longestPrefix)
                      longestPrefix = prefix;
              }


              if (longestSubstring < (longestPrefix + longestAllLetters + longestSuffix))
              {
                  longestSubstring = longestPrefix + longestAllLetters + longestSuffix;
              }



            }


          return longestSubstring;
        }
    }
}
