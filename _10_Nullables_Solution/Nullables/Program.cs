namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a nullable type
            int? num1 = null;
            int num2 = 566;

            double? num3 = new double?();
            double? num4 = 3.5679;

            bool? isTrue = new bool?();

            //Using the Nullable<T> structure directly:
            Nullable<int> num5 = 42; 
            Nullable<int> num6 = null;

            Console.WriteLine("The nullable numbers are: {0}, {1}, {2}, {3}, {4}, {5}", num1, num2, num3, num4, num5, num6);
            Console.WriteLine("The nullable bool is: {0}", isTrue);

            Console.WriteLine();

            //Checking for nullable values using the equality operator

            bool? isFemale = null;

            if( isFemale == true)
            {
                Console.WriteLine("User is female");

            } else if(isFemale == false)
            {
                Console.WriteLine("User is male");
            }else
            {
                Console.WriteLine("No gender selected\n");
            }

            
            //Converting a nullable to non-nullable type

            double? numberValue1 = 34.7;
            double? numberValue2 = null;
            double valueNumber;

            if(numberValue1 == null)
            {
                valueNumber = 0.2;
            }
            else
            {
                valueNumber = (double)numberValue1;
            }

            Console.WriteLine("The value for value number is now {0}\n", valueNumber);

            //null coalescing operator 
            //Converting from nullable to non-nullable type using the null coalescing operator

            valueNumber = numberValue1 ?? 80.9; //assign 80.9 to valueNumber if numberValue is null
            Console.WriteLine("The value for value number is now {0}", valueNumber);

            valueNumber = numberValue2 ?? 8.8;
            Console.WriteLine("The value for value number is now {0}", valueNumber);

            Console.ReadLine();
        }
    }
}