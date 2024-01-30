using System.Threading.Channels;

namespace DateTime_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime julieBirthday = new DateTime(2024, 2, 2);

            Console.WriteLine($"My Dog Julie's birthday is: {julieBirthday}");

            //get the current date
            Console.WriteLine(DateTime.Today);

            //get current time
            Console.WriteLine(DateTime.Now);

            //get the day of the week
            Console.WriteLine($"Today is {DateTime.Today.DayOfWeek}");

            DateTime tomorrow = TomorrowsDate();
            Console.WriteLine($"Tomorrow is: {tomorrow}\n");

            //display the first day of a specific year
            int year = 1999;
            Console.WriteLine($"The firs day of {year} is {FirstDayOfYear(year)}\n");

            //get the day of the week for the first day of the year
            DayOfWeek firstDay = FirstDayOfYear(1990).DayOfWeek;
            Console.WriteLine($"The first day of year 1990 is: {firstDay}");
            
            DayOfWeek first_Day = FirstDayOfYear(2020).DayOfWeek;
            Console.WriteLine($"The first day of year 2020 is: {first_Day}\n");

            //days in month
            int days = DateTime.DaysInMonth(2020, 1);
            Console.WriteLine($"The number of days in January 2020 is: {days}");
            
            int days_2 = DateTime.DaysInMonth(2018, 11);
            Console.WriteLine($"The number of days in November 2018 is: {days_2}");
            
            int days_3 = DateTime.DaysInMonth(1990, 2);
            Console.WriteLine($"The number of days in February 1990 is: {days_3} \n");

            //display minute
            DateTime nowMinute = DateTime.Now;
            Console.WriteLine($"The minute is {nowMinute.Minute}");
            
            //display second
            DateTime nowSecond = DateTime.Now;
            Console.WriteLine($"The second is {nowSecond.Second}");
            
            //display hour, munite and second
            DateTime theTime = DateTime.Now;
            Console.WriteLine($"The time is {theTime.Hour} hours, {theTime.Minute} munites and {theTime.Second} seconds\n");


            //create a little program that tells the time intervals 
            Console.WriteLine("Write your birthday in this format: yyyy-mm-dd");
            string input = Console.ReadLine();

            if(DateTime.TryParse(input, out DateTime dateTime))
            {
                Console.WriteLine(dateTime);
                 
                TimeSpan passedDay = theTime.Subtract(dateTime);
                Console.WriteLine($"You are: {passedDay.Days} days old");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

        }

        //get tomorrow date
        static DateTime TomorrowsDate()
        {
            return DateTime.Today.AddDays(1);
        }
        
        //get tthe first day of year
        static DateTime FirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}