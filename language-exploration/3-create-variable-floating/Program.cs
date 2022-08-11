using System;

namespace create_variables_floating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 - Modifed variable floating");

            double salary = 3000.13;
            Console.WriteLine(salary);

            salary = salary + 1;
            Console.WriteLine(salary);

            Console.WriteLine("Press enter key to exit");
            Console.ReadLine();
        }
    }
}
