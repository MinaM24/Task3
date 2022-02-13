using System;

namespace ConsoleApp1.Task3_2
{
    internal class Program
    {
        /*2) verilmihs 6 reqemli ededin ilk 3 denesinin 
         * reqemleri cemi tap: example: 123600= 1+2+3*/

        static void Main(string[] args)
        {
            int a = 654321;

            bool isSuccess = (a >= 100000 && a < 1000000);
            if (!isSuccess)
            {
                Console.WriteLine("6 reqemli deyil");
                return;
            }

            int b = a / 1000;
            
            int sum = 0;
            int mod;

            while (b > 0)
            {
                mod = b % 10;
                b = b / 10;
                sum = sum + mod;
            }

            Console.WriteLine(sum);
        }
    }
}
