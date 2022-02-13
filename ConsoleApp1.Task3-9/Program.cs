using System;

namespace ConsoleApp1.Task3_9
{
    /*9) 9 reqemli ededdin tek yerde dayananlardan bir 
     * eded duzlet: 132346389=12439*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456789;

            bool isSuccess = (a >= 100000000 && a < 1000000000);
            if (!isSuccess)
            {
                Console.WriteLine("9 reqemli deyil");
                return;
            }
            
            int counter = 1;
            int mod;
            int newNumber = 0;

            while (a>0)
            {
                mod = a % 10;
                a = a / 10;
               
                if (counter % 2 != 0 )
                {
                    newNumber = newNumber * 10 + mod;
                }
                counter++;
            }

            //Console.WriteLine(newNumber);

            a = newNumber;
            newNumber = 0;

            while (a > 0)
            {
                mod = a % 10;
                a = a / 10;
                newNumber = newNumber * 10 + mod; 
            }
            Console.WriteLine(newNumber);
        }
    }
}
