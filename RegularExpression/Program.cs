using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //resding a file
            string textFile =
                              File.ReadAllText(@"C:\RegularExpresionText\TestFile.txt", Encoding.UTF8);
            Console.WriteLine(textFile);
            //spliting input string into array of substring defined by Regular expression- @"\D+"
            string[] numbers = Regex.Split(textFile, @"\D+");
            // removing empty sapce
            numbers = numbers.Except(new List<string> { string.Empty }).ToArray();
            int total_amount = Array.ConvertAll(numbers, s => int.Parse(s)).Sum();

            //spliting input string into array of substring defined by Regular expression- @"\b(?:[a-z]{2,}|[ai])\b"
            string[] strings = Regex.Split(textFile, @"\b(?:[a-z]{2,}|[ai])\b");
            //  removing empty sapce
            strings = strings.Except(new List<string> { string.Empty }).ToArray();
            int total_words = strings.Count();
            
            
            Console.WriteLine("Total amount: " + total_amount);
            Console.WriteLine("Total words: " + total_words);
        }
        
       
        
    }
}
