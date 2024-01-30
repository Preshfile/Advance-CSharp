using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using regular expression
           // string pattern = @"\d"; //find all numbers in the pattern
            //string pattern = @"\d{5}"; //find all numbers in group of 5
            string pattern = @"Hello"; //find the "hello" word


            Regex text = new Regex(pattern);

            string testString = "Hello there! My name is Julie. I am 39 and my number is 777888222333";

            MatchCollection matchCollection = text.Matches(testString);

            Console.WriteLine("{0} hits found:\n{1}", matchCollection.Count, testString);

            foreach(Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
        }
    }
}