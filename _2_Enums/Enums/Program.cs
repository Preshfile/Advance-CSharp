using static Enums.Program;

namespace Enums
{
    internal class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednessday,
            Thurday,
            Friday,
            Saturday,
            Sunday

        }

        public enum MonthsOfTheYear
        {
            January = 1, //setting the index of January to 1
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            
            //Enum for DaysOfTheWeek
            DaysOfTheWeek today = DaysOfTheWeek.Monday;
            Console.WriteLine($"Today is {today}\n");

            foreach (DaysOfTheWeek day in Enum.GetValues(typeof(DaysOfTheWeek)))
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();

            DaysOfTheWeek thisDay = DaysOfTheWeek.Friday;

            Console.WriteLine(thisDay == today); //false

            Console.WriteLine(DaysOfTheWeek.Monday); //Getting the string value
            Console.WriteLine((int)DaysOfTheWeek.Monday); //Getting the index value


            Console.WriteLine("\n");


            //Enum for MonthsOfTheYear
            MonthsOfTheYear thisMonth = MonthsOfTheYear.January;
            Console.WriteLine($"Today is {thisMonth}\n");

            foreach (MonthsOfTheYear month in Enum.GetValues(typeof(MonthsOfTheYear)))
            {
                Console.WriteLine(month);
            }

            Console.WriteLine();

            MonthsOfTheYear theMonth = MonthsOfTheYear.January;

            Console.WriteLine(theMonth == thisMonth); //true

            Console.WriteLine(MonthsOfTheYear.July); //Getting the string value
            Console.WriteLine((int)MonthsOfTheYear.July); //casting into an integer

            Console.WriteLine(MonthsOfTheYear.July); 
            Console.WriteLine((int)MonthsOfTheYear.January); 
        }
    }
}