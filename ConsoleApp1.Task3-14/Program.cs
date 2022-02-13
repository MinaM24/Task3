using System;

namespace ConsoleApp1.Task3_14
{
    internal class Program
    {
        /* 14) 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
         * 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
         * Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
         * Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
         * Neticenin 60 % tap. Cavabin axirina 60 artir.Neticeden 18% cix.*/

        static void Main(string[] args)
        {
            int a = 123456;
            int b = 234567;
            int c = 345678;
            int d = 1234567;


            bool isSuccess = (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 1000000 && d < 10000000);
            if (!isSuccess)
            {
                Console.WriteLine("6 ve ya 7 reqemli deyil");
                return;
            }
            a = a / 1000;
            b = b / 1000;
            c = c / 1000;
            int e = a + b + c;

            int f = d % 10000;
            e = e + f;

            d = d / 10000;

            int multiplied = 1;
            int mod;

            while (d > 0)
            {
                mod = d % 10;
                d = d / 10;
                multiplied = multiplied * mod;
            }
            
            e = e - multiplied;
            e = (e * 60) / 100;
            e = e * 100;
            e = e + 60;
            e = e - (e * 18) / 100;

            Console.WriteLine(e);
        }
    }
}
