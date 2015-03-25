using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    // print out a list of numbers from 1 to 100
    // if the number is divisible by 3 print fizz instead
    // if the number is divisible by 5 print buzz instead
    // if divisible by 3 and 5 print fizzbuzz instead

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                // default condition
                string printOut = i.ToString();

                if ((i % 3) == 0)
                {
                    printOut = "Fizz";
                }

                if ((i % 5) == 0)
                {
                    printOut = "Buzz";
                }

                if (((i % 3) == 0) && ((i % 5) == 0))
                {
                    printOut = "FizzBuzz";
                }

                Console.WriteLine(printOut);
            }

            Console.ReadLine();
        }
    }
}
