namespace Random_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Example: generate a random number 1 - 7 (7 non-inclusive)

            Random dice = new Random();

            int randomNumber;

            for(int i =0; i < 10; i++)
            {
                randomNumber = dice.Next(1, 7);
                Console.WriteLine(randomNumber);
            }

            //Next() method is commonly used to generate random integers.
            //You can specify a range or leave it without parameters to get a non-negative random integer.


            
        }
    }
}