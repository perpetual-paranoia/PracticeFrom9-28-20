using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeGarbage
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeFinder();
        }

        static void AgeFinder()
        {
            int age;
            bool validresponse;

            do
            {
                validresponse = true;

                Console.WriteLine();
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());

                if (age < 0)
                {
                    validresponse = false;

                    Console.WriteLine();
                    Console.WriteLine("How? Just... what? Look, put in an actual age.");
                    Console.WriteLine();
                }

            } while (!validresponse);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
