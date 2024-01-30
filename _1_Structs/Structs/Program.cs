using System.ComponentModel.DataAnnotations;

namespace Structs
{

    struct Game
    {
        //create variables
        public string name;
        public string developer;
        public double rating;
        public string releasedDate;

        //can have a constructor
        public Game(string name, string developer, double rating, string releasedDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releasedDate = releasedDate;

        }

        //a method
        public void Display()
        {
            Console.WriteLine($"First Game's name is : {name}");
            Console.WriteLine($"First Game was developed by: {developer}");
            Console.WriteLine($"First Game's rating is : {rating}");
            Console.WriteLine($"First Game released date is : {releasedDate}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Creating an object of the struct
            Game firstGame = new Game();

            //to be able to use the struct, we have to set values of the variables
            firstGame.name = "Olivia Run";
            firstGame.developer = "Precious Oranye";
            firstGame.rating = 4.3;
            firstGame.releasedDate = "03-04-2020";

            //call the variables onto the console
            Console.WriteLine($"The game '{firstGame.name}' was developed by {firstGame.developer}.\n" +
                             $"It has a rating of {firstGame.rating} and was released on {firstGame.releasedDate}");

            //Or

            Console.WriteLine("\n");
            firstGame.Display();
        }
    }
}