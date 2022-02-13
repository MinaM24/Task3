using System;

namespace ConsoleApp1.Task3_10
{
    /*10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
    sonra cut yerde dayanlarinda bir eded duzlet,
    sonra onlari topla*/

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
            int counter1 = 1;
            int mod1;
            int newNumber1 = 0;
            int a1 = a;

            while (a1 > 0)
            {
                mod1 = a1 % 10;
                a1 = a1 / 10;

                if (counter1 % 2 != 0)
                {
                    newNumber1 = newNumber1 * 10 + mod1;
                }
                counter1++;
            }

            a1 = newNumber1;
            newNumber1 = 0;

            while (a1 > 0)
            {
                mod1 = a1 % 10;
                a1 = a1 / 10;
                newNumber1 = newNumber1 * 10 + mod1;
            }
            Console.WriteLine(newNumber1);

            int counter = 0;
            int mod;
            int newNumber = 0;

            while (a > 0)
            {
                mod = a % 10;
                a = a / 10;

                if (counter % 2 != 0)
                {
                    newNumber = newNumber * 10 + mod;
                }
                counter++;
            }

            a = newNumber;
            newNumber = 0;

            while (a > 0)
            {
                mod = a % 10;
                a = a / 10;
                newNumber = newNumber * 10 + mod;
            }
            Console.WriteLine(newNumber);

            int b = newNumber + newNumber1;
            
            Console.WriteLine(b);




        }
    }
}
