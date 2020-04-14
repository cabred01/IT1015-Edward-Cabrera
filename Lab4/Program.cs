// Edward Cabrera
// 1050 Programming Logic
// Lab 4

using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* For loops is used when we know the amount of time a program needs to be repeated for and while is used when we don't know the amount 
             of repetition. Both of them are used to repeat.*/

            /*It would be more appropiate to use do-while when you want the initial program to execute before checking the condition.
             * For example, if you need a program to run at the miinimum of at least once, then do-while would be best since it can execute the code before checking condition */

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i + " is an even number \n");
                }
                else if ((i % 1) == 0)
                {
                    Console.WriteLine(i + " is an odd number \n");
                }
            }
            Console.Write("Please enter a temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Penguin");
            }
            else if (temp < 40)
            {
                Console.WriteLine("Moose");
            }
            else if (temp < 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (temp < 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temp < 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temp < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temp < 90)
            {
                Console.WriteLine("Fish");
            }
            else
            {
                Console.WriteLine("Bug");
            }

            Console.WriteLine(); //Using cw's to create space between programs, I hope that's okay.

            int x = 10;
            while (x < 21)
            {
                Console.WriteLine(x);
                x++; //the code error was that it didn't add 10, so it continued to go on indefinitely.
            }

            Console.WriteLine();

             for (int z = 0; z < 101; z++)
            {
                Console.WriteLine(z);
                Console.WriteLine("********"); //Forgot curly brackets? I didn't notice since I naturally did it, but I got the same output as the example.
            }

            /* Note: I really appreciate that you showed us what we were to supposed to get. */
        }
    }
}
