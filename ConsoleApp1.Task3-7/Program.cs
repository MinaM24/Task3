using System;

namespace ConsoleApp1.Task3_7
{
    /*7) verilmihs 4 reqemli ededin tersine 
     * duzub axirina ve evveline 8 artir*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;

            bool isSuccess = (a >= 1000 && a < 10000);
            if (!isSuccess)
            {
                Console.WriteLine("4 reqemli deyil");
                return;
            }

            int mod;
            int newNumber = 0;
            while (a > 0)
            {
                mod = a % 10;
                newNumber = newNumber * 10 + mod;
                a /= 10;
            }
            //Console.WriteLine(newNumber);

            newNumber = newNumber + 80000;
            newNumber = newNumber * 10 + 8;

            Console.WriteLine(newNumber);

        }
    }
}
