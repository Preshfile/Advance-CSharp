namespace CommandLine_App_With_Main_Args
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to Smart Args Application");

            if (args.Length == 0)
            {
                Console.WriteLine("This smart application uses args Please provide arguments." +
                              "Otherwise, Pass help for more details");
                Console.ReadKey();
                //quit the application entirely since we can't proceed further since, the arguments are empty
                return;
            }

            if (args[0] == "help")
            {
                //Program instructions
                Console.WriteLine("++++++++++++++++ Instructions +++++++++++++++++\n");
                Console.WriteLine("Type any of the two commands, and then provide two numbers: ");
                Console.WriteLine("'add' - to add two numbers,");
                Console.WriteLine("'sub' - to subtract two numbers,");
                Console.WriteLine("          ++++++++++++++++++++++++++++++          \n");
            }
            //check user input
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid command! Please use the 'help' command for instructions");
                Console.ReadKey();
                //quit the application
                return;
            }
            //Try parse the input
            bool isFirstNumParse = float.TryParse(args[1], out float firstNum);
            bool isSecondNumParse = float.TryParse(args[1], out float secondNum);

            if (!isFirstNumParse || !isSecondNumParse)
            {
                Console.WriteLine("Invalid command! Please use the 'help' command for instructions");
                Console.ReadKey();
                //quit the application
                return;
            }

            //a variable to store the results
            float result;

            switch (args[0])
            {
                //case 1 'add add the two numbers and print the value
                case "add":
                    result = firstNum + secondNum;
                    Console.WriteLine("The sum of {0} and {1} is {2}", firstNum, secondNum, result);
                    break;

                //case 2 'sub' subtract the two numbers and print the value
                case "sub":
                    result = firstNum - secondNum;
                    Console.WriteLine($"The sub of {0} and {1} is {1}", firstNum, secondNum, result);
                    break;

                //default case for printing of error message
                default:
                    Console.WriteLine("Invalid arguments, please use the help command for instructions");
                    break;
            }

            Console.ReadKey();
        }
    }

}
    