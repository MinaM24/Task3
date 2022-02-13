using System;

namespace ConsoleApp1.Task3_11
{
    internal class Program
    {
        /*11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
         * Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
         * Sonra cavabin ozunden onun 18% ni cix;*/

        static void Main(string[] args)
        {
            int a = 12345678;

            bool isSuccess = (a >= 10000000 && a < 100000000);
            if (!isSuccess)
            {
                Console.WriteLine("8 reqemli deyil");
                return;
            }

            int b = a % 100;
            a = a / 100;
            int c = a % 100;
            a = a / 100;
            int d = a % 100;
            a = a / 100;

            int e = a + b + c + d;
            e = e * 100;
            e = e + 99;
            e = e - (e * 18 / 100);

            Console.WriteLine(e);




         

        }
    }
}
