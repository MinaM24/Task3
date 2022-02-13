using System;

namespace ConsoleApp1.Task3_6
{
    internal class Program
    {
        /*6) verilmihs 8 reqemli ededin ilk I ve 
         * axirinci reqemlerini legv et*/

        static void Main(string[] args)
        {
            int a = 42345679;

            bool isSuccess = (a >= 10000000 && a < 100000000);
            if (!isSuccess)
            {
                Console.WriteLine("8 reqemli deyil");
                return;
            }
            int b = a % 10;
            a = (a - b)/10;

            int c = a / 1000000;
            a= a - (c*1000000);

            Console.WriteLine(a);
        }
    }
}
