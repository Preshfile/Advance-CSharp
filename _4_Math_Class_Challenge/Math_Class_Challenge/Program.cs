namespace Math_Class_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First method call
            Run("20");

            //Second method call
            Run2("20");


            //First method

            static double ConvertToRadians(double angle)
            {
                return (Math.PI / 180) * angle;
            }

            static void Run(string line)
            {

                try
                {
                    int number = int.Parse(line);

                    if (number >= 0 && number <= 180)
                    {
                        double radianValue = ConvertToRadians(number);

                        Console.WriteLine($"Cos = {Math.Cos(radianValue)}");
                        Console.WriteLine($"Sin = {Math.Sin(radianValue)}");
                        Console.WriteLine($"Tg = {Math.Tan(radianValue)}");
                    }
                    else
                    {
                        Console.WriteLine("Check the input!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Check the input!");
                }
            }

            //Second Method

            static double ConvertToRadians2(double angle)
            {
                return (Math.PI / 180) * angle;
            }

            static void Run2(string line)
            {
                // TODO

                if (int.TryParse(line, out int number) ){

                    if(number >= 0 && number <= 180)
                    {
                        double radianValue = ConvertToRadians(number);

                        Console.WriteLine($"\nCos = {Math.Cos(radianValue)}");
                        Console.WriteLine($"Sin = {Math.Sin(radianValue)}");
                        Console.WriteLine($"Tg = {Math.Tan(radianValue)}");
                    }
                    else
                    {
                        Console.WriteLine("Check the value!");
                    }
                }
                else
                {
                    Console.WriteLine("Parsing was not successful!");
                }
             }
        }
    }
}