using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQquestions
{
    public class LINQ
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

        //public static string[] RemoveLowestNumber(string item)
        //{
        //    // convert
        //    var output = item.Split(',').OrderByDescending(i => int.Parse(i)).ToList();
        //    output.RemoveAt(item.Length -1);
        //    return output.ToArray();
        //}

        public static string[] RemoveLowestNumber(string item)
        {
            // convert
            var output = item.Split(',').OrderBy(i => int.Parse(i)).ToList();
            output.RemoveAt(0);
            return output.ToArray();
        }

        public static double[] StringToDouble(string[] item)
        {
            double[] doubleArray = new double[item.Length];
            for (int i = 0; i < item.Length; i++)
            {
                doubleArray[i] = double.Parse(item[i]);
            }
            return doubleArray;
        }

        // Run separate methods together
        public static List<double> AverageNumbers(List<string> items)
        {
            List<double> averages = new List<double>();
            foreach (string item in items)
            {
                string[] grades = RemoveLowestNumber(item);
                double[] gradesAsDoubles = StringToDouble(grades);
                double average = gradesAsDoubles.Average();
                averages.Add(average);
            }
            return averages;
        }

        public static double AverageGrade(List<double> items)
        {
            return items.Average();
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
            var zippedList = input.Zip(counted, (i, c) => i + "" + c + "|"); // Need to add the + "" + otherwise it displays the character unicode number

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
