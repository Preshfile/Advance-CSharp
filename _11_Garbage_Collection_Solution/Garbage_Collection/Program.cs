namespace Garbage_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example
            Human firstPerson = new Human("Victor", 39);

            firstPerson.Teach();

            firstPerson.GetOlder();

            /* once all the information about the object firstPerson runs to the end of this function
               it gets out of scope and there are no reference to firstPerson left.
               The garbage collector cleans up firstPerson and reallocate its memory

             */
        }
    }
}