// Edward Cabrera
// 1050 Programming Logic
// Lab 3
using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit = 35;
            int speed = 42;
            Console.WriteLine($"Speed limit: {speedLimit}");
            Console.WriteLine($"Your speed is: {speed}");
            if (speed > speedLimit)
            {
                string message = "SLOW DOWN";
                Console.WriteLine(message);
            }

            int isTrue = 35;
            if (isTrue > 20)
            {
                Console.WriteLine("This is True!");
            }
            else 
            {
                Console.WriteLine("This is False!");
            }

            if (isTrue < 20)
            {
                Console.WriteLine("This is True!");
            }
            else
            {
                Console.WriteLine("This is False!");
            }

            bool isTrue1 = true; //Please clarify the type we gotta use next time. I used both bool and int for this because it wasn't clear. 
            if (isTrue1)
            {
                
                Console.WriteLine("This is True!");
            }
            else
            {
                Console.WriteLine("This is False!");
            }

 
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine("The counter is " + counter++);
            }

            int secondCounter = 60;
            while (secondCounter >= 20)
            {
                Console.WriteLine("The second counter is " + secondCounter);
                secondCounter -= 5;
            }

            int thirdCounter = 10;
            while (thirdCounter <= 20)
            {
                Console.WriteLine("The third counter is " + thirdCounter);
                thirdCounter += 2;
            }

            /*If-statements and while loops are similar in the way that both will execute if conditions are met.
             The difference between the two is that if-statements will execute once and while statement can repeatedly execute*/
        }
    }
}
