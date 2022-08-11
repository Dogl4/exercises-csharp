using System;

namespace _4_ConvertersAndOtherTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 3000.185;
            Console.WriteLine(salary);
  
            int salaryInt = (int)salary;
            Console.WriteLine(salaryInt);

            long x;
            x = 20000000000;
            Console.WriteLine(x);

            short y;
            y = 15000;
            Console.WriteLine(y);

            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }
    }
}
