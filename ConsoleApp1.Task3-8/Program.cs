using System;

namespace ConsoleApp1.Task3_8
{
    /*8) Verilmis ededdin axirdan 3-cu reqemi ile 
     * sonuncu reqeminin cemini tap */

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 65232479;
         

            bool isSuccess = (a >= 1000);
            if (!isSuccess)
            {
                Console.WriteLine("4 reqemli deyil (en azi 4 reqemli eded olmalidir");
                return;
            }
            int b = a % 10;

            int c = a % 1000;
            c = c / 100;

            int d = b + c;

            Console.WriteLine(d);

        }
    }
}
