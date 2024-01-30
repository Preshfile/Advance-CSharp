namespace Math_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Rounding a number - Ceiling, Floor
            double firstNumber = 45.9;
            Console.WriteLine($"First number is ceiled to: {Math.Ceiling(firstNumber)}"); // Roundup - return 46
            Console.WriteLine($"First number is floored to: {Math.Floor(firstNumber)}"); //Round down - return 45

            //Min and Max
            int secondNumber = 200;
            int thirdNumber = 120;

            int maxResult = Math.Max(secondNumber, thirdNumber);
            int minResult = Math.Min(secondNumber, thirdNumber);
            Console.WriteLine($"\nThe maximum number between {secondNumber} and {thirdNumber} is: {maxResult}");
            Console.WriteLine($"The minimum number between {secondNumber} and {thirdNumber} is: {minResult}\n");

            //OR
            Console.WriteLine($"The maximum number between {secondNumber} and {thirdNumber} is: {Math.Max(secondNumber, thirdNumber)}");
            Console.WriteLine($"The minimum number between {secondNumber} and {thirdNumber} is: {Math.Min(secondNumber, thirdNumber)}\n");

            //Exponential
            Console.WriteLine($"10 raised to the power of 2 is: {Math.Pow(10, 2)}\n");

            //PI
            Console.WriteLine($"PI is: {Math.PI}\n");

            //Square Root
            Console.WriteLine($"The square root of 225 is: {Math.Sqrt(225)}\n");

            //Absolute Value - returns positive values
            Console.WriteLine($"The absolute value of -100 is: {Math.Abs(-100)}\n");

            //Cos
            Console.WriteLine($"The Cos of 5 is : {Math.Cos(5)}");


            //There are many more methods available
        }
    }
}