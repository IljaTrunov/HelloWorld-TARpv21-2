using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //program asks the user to enter their first name
            //program greets the user using their first name

            Console.WriteLine("enter your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();

            //Console.WriteLine("Hello " + firstName + "!");

            //string interpolation
            Console.WriteLine($"Hello, {firstName},{surname}!");

            //program asks the user to enter their surname
            //program greets the user using their surname

           
            Console.Read();
        }
    }
}
