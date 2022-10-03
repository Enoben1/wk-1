
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
namespace HelloWorld
{
    class Result
    {

        /*
         * Complete the 'matchingStrings' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY stringList
         *  2. STRING_ARRAY queries
         */

        public static List<int> matchingStrings(List<string> stringList, List<string> queries)
        {
            List<int> totalList = new List<int>();
            foreach (var qitem in queries)
            {
                int total = 0;
                foreach (var sitem in stringList)
                {
                    if (sitem == qitem)
                    {
                        total += 1;
                    }
                }
                totalList.Add(total);
            }
            return totalList;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            string value;
                    // Check whether the environment variable exists.
            value = Environment.GetEnvironmentVariable("OUTPUT_PATH");
            // If necessary, create it.
            if (value == null)
            {
                Environment.SetEnvironmentVariable("OUTPUT_PATH", "C:\\work/wk-1/enes.log");
                

                // Now retrieve it.
                value = Environment.GetEnvironmentVariable("OUTPUT_PATH");
            }
            // Display the value.
            Console.WriteLine($"OUTPUT_PATH: {value}\n");


            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int stringListCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> stringList = new List<string>();

            for (int i = 0; i < stringListCount; i++)
            {
                string stringListItem = Console.ReadLine();
                stringList.Add(stringListItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> res = Result.matchingStrings(stringList, queries);

            textWriter.WriteLine(String.Join("\n", res));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}