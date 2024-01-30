namespace Main_Args
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            if (args.Length == 0)
            {
                Console.WriteLine("This smart application uses args Please provide arguments next time");
                //pause the application so it doesn't quite after printing our error message
                
                Console.ReadKey();
                //quit the application entirely since we can't proceed further since, the arguments are empty
                return;
            }
            Console.WriteLine("Hello" + args[0]);
        }
    }
}