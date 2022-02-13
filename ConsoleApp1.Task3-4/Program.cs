using System;

namespace ConsoleApp1.Task3_4
{
    internal class Program
    {
        /*4) verilmihs 5 reqemli ilk ve son reqemlerinin 
         * ceminin kvadrati*/

        static void Main(string[] args)
        {
            int a = 32345;

            bool isSuccess = (a >= 10000 && a < 100000);
            if (!isSuccess)
            {
                Console.WriteLine("5 reqemli deyil");
                return;
            }

            int b = a % 10;
            int c = a / 10000;
            double p = Math.Pow((b+c), 2);
            Console.WriteLine(p);

        }
    }
}
