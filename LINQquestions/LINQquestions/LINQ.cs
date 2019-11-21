using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQquestions
{
    class LINQ
    {
        public void FindSubString()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            words = words.Where(w => w.Contains("th")).ToList();
            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
        }

        public void NoDuplicates()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            names = names.Distinct().ToList();
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }

        public static string[] RemoveLowestNumber(string item)
        {
            // convert
            var output = item.Split(',').OrderByDescending(i => int.Parse(i)).ToList();
            output.RemoveAt(item.Length -1);
            return output.ToArray();
        }

        //public static string[] RemoveLowestNumber(string item)
        //{
        //    // convert
        //    var output = item.Split(',').OrderBy(i => int.Parse(i)).ToList();
        //    output.RemoveAt(0);
        //    return output.ToArray();
        //}

        public static double[] AverageNumbers(double[] scores) // Not working yet
        {
            // Loop through each string
            // Sort through string
            // Drop the lowest number
            // Average the numbers of each index[?]
            // Average the entire collection

            List<string> classGrades = new List<string>()
            {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
            };
            foreach (var grade in classGrades)
            {
                Console.WriteLine("Test");
            }
            Console.WriteLine(classGrades);
            Console.ReadLine();
            return scores;
        }

        public void AlphabeticalString(string personName)
        {
            var input = personName.ToUpper().OrderBy(i => i).Distinct().ToList();  // Setting as Char // Gets 'E','I','L','R','T'
            var counter = personName.ToUpper().OrderBy(i => i).GroupBy(g => g).ToList(); // Setting number of repetitions to a list
            List<int> counted = new List<int>();

            foreach (var charGroup in counter)
            {
                counted.Add(charGroup.Count()); // Setting as Int // Gets 1,1,2,2,1
            }
            var zippedList = input.Zip(counted, (i, c) => i + "" + c); // Need to add the + "" + otherwise it displays the character unicode number

            string result = "";
            foreach (var item in zippedList)
            {
                result += item;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
