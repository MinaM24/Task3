using System;

namespace ConsoleApp1.Task3_12
{
    internal class Program
    {
        /*12) 2 dene 5 reqemli eded daxil et.
         * I ededin reqemleri ceminin usutne
         * II ededin reqemleri hasilini gel.
         * Neticenin axirina I ededin en axinci reqemini artir.*/

        static void Main(string[] args)
        {
            int a = 12345;
            int b = 65432;

            bool isSuccess = (a >= 10000 && a < 100000 && b >= 10000 && b < 100000);
            if (!isSuccess)
            {
                Console.WriteLine("5 reqemli deyil");
                return;
            }

            int sum = 0;
            int mod1;

            while (a > 0)
            {
                mod1 = a % 10;
                a = a / 10;
                sum = sum + mod1;
            }

            int d = sum % 10;        

            int multiplied = 1;
            int mod2;

            while (b > 0)
            {
                mod2 = b % 10;
                b = b / 10;
                multiplied = multiplied * mod2;
            }

            int c = sum + multiplied;
            c = (c * 10) + d;

            Console.WriteLine(c);




        }
    }
}
