// Edward Cabrera
// IT 1050 - Programming Logic
// Lab 2 

using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Edward";
            string lastName = "Cabrera";
            string Major = "Computer Science";
            int a = 12;
            int b = 20;
            int sum = a + b;
            string sumString = "The sum is";
            int number1 = 3;
            int number2 = 4;
            int number3 = 5;
            int average = ((number1 + number2 + number3) / 3);
            int pi;
            double piDouble;
            decimal decimalPi;

            pi = 355 / 113;
            piDouble = 355d / 113d;
            decimalPi = 355m / 113m;

            Console.WriteLine($"Hello, {firstName}!");

            Console.WriteLine($"{firstName} {lastName}'s major is {Major}");


            Console.WriteLine(a + b);
            Console.WriteLine($"{sumString} {sum + a + b}"); // In the previous code, the output is the sum of integer a and b 
                                                             //while this line of code is the addition of the sum of the two numbers and the two numbers
                                                             // The meaning of the + operator changes after adding variable sum by adding the two integers together with the sum.
                                                             // Sum changes the statement by combining them together

            Console.WriteLine($"The average number is of 3, 4, and 5 is equal to {average}");
            Console.WriteLine("Int: " + pi); // rounds to a whole number; lesser precision
            Console.WriteLine("Double: " + piDouble); // shows decimals to an extent; in-between precision
            Console.WriteLine("Decimal: " + decimalPi); // shows even more decimal; more precise number
        }
    }
}
