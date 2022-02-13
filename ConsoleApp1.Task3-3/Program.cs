using System;

namespace ConsoleApp1.Task3_3
{
    internal class Program
    {
        /*3) verilmihs 9 reqemli ededin duz ortaya dushen 3 
         * reqeminin reqemleri cemi*/

        static void Main(string[] args)
        {
            int a = 123752789;

            bool isSuccess = (a >= 100000000 && a < 1000000000);
            if (!isSuccess)
            {
                Console.WriteLine("9 reqemli deyil");
                return;
            }

            a = a / 1000;      
            a= a % 1000;

            int sum = 0;
            int mod;

            while (a > 0)
            {
                mod = a % 10;
                a = a / 10;
                sum = sum + mod;
            }

            Console.WriteLine(sum);
        }
    }
}
