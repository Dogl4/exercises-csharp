using System;

namespace create_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 - Modifed variable");

            int age = 27;
            Console.WriteLine("My age is: " + age);
            age = 5 * 2 - 6;
            Console.WriteLine("My age is: " + age);
            age = 5 * 2 - 6;
            Console.WriteLine("My age is: " + age);

            Console.WriteLine("Input enter to exit...");
            Console.ReadLine();
        }
    }
}
