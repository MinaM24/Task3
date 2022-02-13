using System;

namespace ConsoleApp1.Task3_1
{
    /*1)verilmish 4 reqemli ededin reqemlerinin cemini tap*/

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

            int sum=0;
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
