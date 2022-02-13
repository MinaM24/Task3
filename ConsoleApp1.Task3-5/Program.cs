using System;

namespace ConsoleApp1.Task3_5
{
    internal class Program
    {
        /*5) verilmihs 6 reqemli ededin 1 ci reqemini hemin 
         * ededin axirina at.*/

        static void Main(string[] args)
        {
            int a = 123456;

            bool isSuccess = (a >= 100000 && a < 1000000);
            if (!isSuccess)
            {
                Console.WriteLine("6 reqemli deyil");
                return;
            }
            int mod = a % 100000;
            a = (a - mod) / 100000;
            a = mod * 10 + a;

            Console.WriteLine(a);


        }
    }
}
