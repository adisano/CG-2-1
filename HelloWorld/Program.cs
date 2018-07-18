using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings, HUMAN! Please enter your FIRST NAME and depress ENTER KEY: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Human.NameLog(" + firstName + ")... Processing...");
            Console.WriteLine("Please enter your LAST NAME and depress ENTER KEY: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("LOADING TOTALLY HUMAN GREETING PROTOCOLS...");
            Console.WriteLine("Setup: OK! Loading Greeting... 100%! HELLO" + " " + firstName + " " + lastName + "!");
            Console.ReadLine();
        }
    }
}
