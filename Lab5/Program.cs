// Edward Cabrera
// 1050 Programming Logic
// Lab 5
// 4/20/2020

using System;

namespace Lab5
{
    class Program
    {
        static void Main()
        {
            /* A one-dimensional array p contains four elements. The array access expressions to access
            each of the elements in p are p[0], p[1], p[2], and [p3] */

            string[] seasons = new string[4] { "Spring", "Summer", "Autumn", "Winter" };
            foreach (string a in seasons)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine(); //space

            int randomNumber;
            string[] random = new string[1000];
            Random rnd = new Random();
            foreach (string a in random)
            {
                randomNumber = rnd.Next(0, 100);
                Console.WriteLine(randomNumber); //Are we supposed to create a 1000 numbers from 0 to 100? Instructions not clear.
            }
       
            Console.WriteLine(); //space

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger", "Rayle", "Iona Ford" };
            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i]); //Changed 0 to i, added i++ and fixed some names inside the brackets.
                i++;
            }

            Console.WriteLine(); //space

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int a = 0; 0 < months.Length; a++)
            {
                Console.WriteLine(months[a]);
            }

            /*  Another alternative would be:
             *  
              string[] months = new string[12];
              months[0] = "January";
              months[1] = "February";
              months[2] = "March";
              months[3] = "April";
              months[4] = "May";
              months[5] = "June";
              months[6] = "July";
              months[7] = "August";
              months[8] = "September";
              months[9] = "October";
              months[10] = "November";
              months[11] = "December"; */
        }
    }
}
