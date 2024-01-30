namespace RandomClass_Challenge_FortuneTeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t ***** WELCOME TO FORTUNE TELLING! *****\n");
            Random card = new Random();

            int fortuneTeller;

            do
            {
                Console.WriteLine("Choose a number from 1 - 3 to know your fortune");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "X")
                {
                    break; // Terminate the loop if the user enters x
                }

                Console.WriteLine("\nYour chosen card is: '{0}'", userInput);

                bool correctInput = int.TryParse(userInput, out fortuneTeller);

                if (correctInput && fortuneTeller < 4 && fortuneTeller > 0)
                {
                    Console.WriteLine("Your fortune is...\n");

                    fortuneTeller = card.Next(1, 4);

                    if (fortuneTeller == 1)
                    {
                        Console.WriteLine("\tYOUR LIGHT WILL SHINE!\n");
                    }
                    else if (fortuneTeller == 2)
                    {
                        Console.WriteLine("\tYOU WERE HERE!\n");
                    }
                    else
                    {
                        Console.WriteLine("\tDON'T GO BACK\n");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input! Please enter 1, 2 or 3\n");
                }
            } while (true);
        }
    }
}