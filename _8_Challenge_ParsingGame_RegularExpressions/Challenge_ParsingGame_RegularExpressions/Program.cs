using System.Text.RegularExpressions;

namespace Challenge_ParsingGame_RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             download our input.txt from the sources for this lesson and start a new console project.

             Subject:

             Read and store the whole text from the source file;

             Using regular expressions find all sequences of numbers that has length 2 or 3;

             Pars every value into an integer;

             Use casting to convert every integer into a char. It will look like that:

             (char)YourValue;
             and just print the result of each cast on the new line;



             Questions for this assignment
             What is the result of the two parts of the game?

             (if you have no idea what was the part one, check Parsing game (part 1))



             Hint: if it is not a readable sentence, your answer is wrong.

             */


            try
            {
                // Read the content of the input.txt file
                string filePath = "C:\\Users\\UNIK\\Pictures\\_perso\\Advance CSharp\\Challenge_ParsingGame_RegularExpressions\\Challenge_ParsingGame_RegularExpressions\\input2.txt"; 
                string fileContent = File.ReadAllText(filePath);

                // Use regular expressions to find sequences of numbers with length 2 or 3
                Regex regex = new Regex(@"\b\d{2,3}\b");
                MatchCollection matches = regex.Matches(fileContent);

                // Parse each matched value into an integer, cast to char, and print the result
                foreach (Match match in matches)
                {
                    if (int.TryParse(match.Value, out int intValue))
                    {
                        char charValue = (char)intValue;
                        Console.Write(charValue);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}