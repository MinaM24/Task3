using System;

namespace ConsoleApp1.Task3_13
{
    internal class Program
    {
        /* 13) 3 dene 5 reqemli eded var.
         * Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. 
         * Alinan neticeleri topla.
         * Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.*/

        static void Main(string[] args)
        {
            int a = 72343;
            int b = 23456;
            int c = 34567;

            bool isSuccess = (a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000);
            if (!isSuccess)
            {
                Console.WriteLine("5 reqemli deyil");
                return;
            }

            int d = a % 10;
            a = a / 10000;
            a = a * 10 + d;

            int e = b % 10;
            b = b / 10000;
            b = b * 10 + e;

            int f = c % 10;
            c = c / 10000;
            c = c * 10 + f;

            double g = a + b + c + ((a + b + c) * 0.5);

            Console.WriteLine(g);

        }
    }
}
